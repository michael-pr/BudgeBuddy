(function (ko, dataconext) {
    datacontext.goalItem = goalItem;
    datacontext.goalList = goalList;

    function goalItem(data) {
        var self = this;
        data = data || {};

        self.goalItemId = data.goalItemId;
        self.title = ko.observable
    }

})