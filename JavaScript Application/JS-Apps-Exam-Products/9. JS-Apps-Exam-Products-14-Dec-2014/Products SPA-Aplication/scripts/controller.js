'use strict';

var app = app || {};

app.controller = (function() {

    function BaseController(data) {
        this._data = data;
    }

    BaseController.prototype.login = function() {

        var self = this;
      var userData = {
          username: $('#username').val(),
          password: $('#password').val()
      };

        this._data.user.login(userData).then(
        function(data) {
            console.log(userData)
            self._data.user.setUserData(data);
            window.location = '#/home';
            console.log('login ok');
        },
        function (error) {
            console.log('login ne e e ok' + error);
            window.location = '#/login';
        })
    };

    BaseController.prototype.register = function() {
        var self = this;
        var userData = {
            username : $('#username').val(),
            password : $('#password').val()
        };

        var confirmPassword = $('#confirm-password').val();

        if(confirmPassword != userData.password) {
            console.log('confirm pass is wrong');
            window.location = '#/register';
            return;

        }

        this._data.user.register(userData).then(
            function(data) {
                console.log(userData);
                self._data.user.setUserData(data);
                console.log('register ok');
                window.location = '#/home';
            },
            function(error) {
                console.log('register error');
                window.location = '#/register';
            })
    };

    BaseController.prototype.logout = function() {
        console.log('logout ok');
         this._data.user.logout();

    };

    BaseController.prototype.loadMenu = function(selector) {

        var menuSelector = $(selector);

        if (this._data.user.isLogged()){
            $(menuSelector[0]).hide();
            $(menuSelector[1]).show()
        } else {
            $(menuSelector[0]).show();
            $(menuSelector[1]).hide()
        }
    };

    BaseController.prototype.loadHome = function(selector) {
        var self = this;

        if (this._data.user.isLogged()) {
            $.get('templates/home.html', function(view) {
                var currentUser = self._data.user.getUserData();
                var output = Mustache.render(view, currentUser);
                $(selector).html(output);
            });
        }else {
            $(selector).load('templates/welcome.html')
        }
    };

    function getfilters() {
        var filters = {};

        var searchBar =  $('#search-bar').val();
        var minPrice = $('#min-price').val();
        var maxPrice= $('#max-price').val();
        var category = $('#category').val();

        if(searchBar.length > 0) {
            filters.name = searchBar;
        }


        return filters;
    }

    BaseController.prototype.getProducts = function(selector) {
        var products;
        var filter = getfilters();
        var filters = {where:JSON.stringify(filter)};


        this._data.products.getAllProducts(filters).then(
            function(data) {
                products = data;
                $.get('templates/products-list.html', function(view) {
                    var output = Mustache.render(view, data);
                    $(selector).html(output);

                });
                console.log('products loaded!');
            },
            function(error) {
                console.log('products not load!' + error);
            })
    };



    return {
        get: function (data) {
            return new BaseController(data);
        }
    }
})();