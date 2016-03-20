var app = app || {};

app.homeController = (function() {

    function HomeController(viewBag) {
        this._viewBag = viewBag;
    }

    HomeController.prototype.loadGuestMenu = function(selector) {
        this._viewBag.GuestMenu.load(selector);
    };

    HomeController.prototype.loadWelcomeGuest = function(selector) {
        this._viewBag.welcomeGuest.load(selector);
    };

    HomeController.prototype.loadHomeMenu = function(selector) {
        this._viewBag.homeMenu.load(selector);
    };

    HomeController.prototype.loadWelcomeUser = function(selector) {
        var data = {
            username: sessionStorage['username']
        };

        this._viewBag.welcomeUser.load(selector, data);
    };

    return {
        load: function(viewBag) {
            return new HomeController(viewBag);
        }
    }

}());
