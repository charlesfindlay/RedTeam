function RokuViewModel() {
    // Data
    var self = this;
    self.ChosenRemoteButton = ko.observable();
    self.ChosenQuickListID = ko.observable();
    var selectedRoku = "10.251.1.162";
    var value = null;

    // Behaviors
    self.myKeypress = function () {
        var request = "http://10.251.1.162:8060/keypress/home";
        $.post(request);

        //var request = "http://" + selectedRoku + ":8060/keypress/" + value;
        //xmlhttp.open("POST", request, true);
        //xmlhttp.send();

    }

};

ko.applyBindings(new RokuViewModel());