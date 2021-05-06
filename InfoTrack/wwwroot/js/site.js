$(document).ready(function () {
    var vm = {
        keywords: ko.observable(),
        uri: ko.observable(),
        results: ko.observable(),
        searching: ko.observable(false),
        search: function () {
            var self = this;
            self.searching(true);
            $.ajax({
                type: "GET",
                url: `/home/searchseo?keywords=${self.keywords()}&uri=${self.uri()}`,
                dataType: "json"
            }).done(function (response) {
                if (response) {
                    self.results(response.toString());
                } else {
                    self.results("No results found in the top 100 indexed positions at this time")
                }
            }).fail(function () {
                self.results("An unexpected error occured processing your request, please try your search again.")
            }).always(function () {
                self.searching(false);
            });
        }
    };
    ko.applyBindings(vm);
    $('#keywords').on("keyup", function () {
        vm.keywords($(this).val());
        vm.keywords.valueHasMutated();
    });
    $("#uri").on("keyup", function () {
        vm.uri($(this).val());
        vm.uri.valueHasMutated();
    })
});
