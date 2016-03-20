var app = app || {};

app.homeView = (function() {
    function HomeView() {
        this.GuestMenu = {
            load: loadGuestMenu
        };
        this.welcomeGuest = {
            load: loadWelcomeGuest
        };
        this.welcomeUser = {
            load: loadWelcomeUser
        };
        this.homeMenu = {
            load: loadHomeMenu
        };
    }

    function loadGuestMenu(selector) {

        $.get('templates/menu-login.html', function(template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);
        })
    }

    function loadWelcomeGuest(selector) {

        $.get('templates/welcome-guest.html', function(template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);
        })
    }

    function loadWelcomeUser(selector, data) {

        $.get('templates/welcome-user.html', function(template) {
            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);
        })
    }

    function loadHomeMenu(selector) {

        $.get('templates/menu-home.html', function(template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);
        })
    }


    return {
        load: function() {
            return new HomeView();
        }
    }

}());
