'use strict';

var app = app || {};

(function() {

    var baseUrl = 'https://api.parse.com/1/';
    var selector = $('#main');
    var menuSelector = $('#menu ul');
    var requester =  app.requester;
    var data = app.service.data(baseUrl, requester );
    var controller = app.controller.get(data);

    app.route = Sammy(function() {

        this.get('#/', function () {
            controller.loadMenu(menuSelector);
            controller.loadHome(selector);
        });
        this.get('#/home', function () {
            controller.loadMenu(menuSelector);
            controller.loadHome(selector);
       });
        this.get('#/login', function () {
            controller.loadMenu(menuSelector);
            $(selector).load('templates/login.html');
        });
        this.get('#/do-login', function () {
            controller.login();
        });
        this.get('#/register', function () {
            $(selector).load('templates/register.html');
            controller.loadMenu(menuSelector);

        });
        this.get('#/do-register', function () {
            controller.register();
            controller.loadMenu(menuSelector);

        });
        this.get('#/logout', function () {
            controller.loadMenu(menuSelector);
            controller.logout();
            window.location = '#/'
        });
        this.get('#/products', function () {
            controller.loadMenu(menuSelector);
            controller.getProducts(selector);
            $(selector).load('templates/products-list.html')
        });
        this.get('#/add-products', function () {
            $(selector).load('templates/add-products.html')
        });
        this.get('#/edit-products', function () {
            $(selector).load('templates/edit-products.html')
        });
        this.get('#/delete-products', function () {
            $(selector).load('templates/delete-products.html')
        });

    }).run('#/');
})();
