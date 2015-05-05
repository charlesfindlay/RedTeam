function RokuViewModel() {
    // Data
    var self = this;
    self.ChosenRemoteButton = ko.observable();
    self.ChosenQuickListID = ko.observable();
    var selectedRoku = "10.251.1.162";
    var value = null;

    // Behaviors
    self.myKeypress = function (value) {
        var request = "http://10.251.1.162:8060/keypress/home";
        //var request = "http://" + selectedRoku + ":8060/keypress/" + value;
        //xmlhttp.open("POST", request, true);
        //xmlhttp.send();
        $.post(request);
    }

};

ko.applyBindings(new RokuViewModel());