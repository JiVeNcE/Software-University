'use strict';

var app = app || {};

app.service = (function() {

    var Data = (function(){

        function Data (baseUrl, requester){
            this.user = new User(baseUrl, requester);
            this.products = new Products(baseUrl, requester);
        }

        return Data;
    })();
    
    var credential = (function () {

        function getHeaders() {
            var headers = {
                'X-Parse-Application-Id': 'dDiUgO7fzT3FUKoS5qfI92gpvufAHR0B0j0eCmat',
                'X-Parse-REST-API-Key': 'VFC5YBMakCTKq9U3XnjhVaRRm2dpgnqrON2TBAMs'
            };

            var currentUser = getSessionToken();

            if(currentUser) {
                headers['X-Parse-Session-Token'] = currentUser;
            }

            return headers;
        }

        function getSessionToken() {
            var userData = JSON.parse(sessionStorage.getItem('userData'));
            if(userData) {
                return userData.sessionToken;
            }

            return false;
        }

        function getUserName() {
            var currentUser = JSON.parse(sessionStorage.getItem('userData'));
            if(currentUser){
                return currentUser.username;
            }
        }

        function getUserData() {
           return sessionStorage.getItem('userData');
        }

        function setUserData(userData) {
            sessionStorage.setItem('userData', userData);
        }

        function isLogged(){
            var currentUser = getSessionToken();
            if(currentUser) {
                return true;
            }
            return false;
        }

        function deleteUser() {
            sessionStorage.clear();
        }

        return {
            getHeaders: getHeaders,
            isLogged: isLogged,
            getUserName: getUserName,
            getUserData: getUserData,
            setUserData: setUserData,
            deleteUser: deleteUser
        }

    })();
    

    var User = (function() {

        function User (baseUrl, ajaxRequest) {
            this._baseUrl = baseUrl;
            this._ajaxRequester = ajaxRequest;
        }

        User.prototype.isLogged = function() {

            return credential.isLogged();
        };
        
        User.prototype.login = function (userData) {
            var url = this._baseUrl + 'login';
            return this._ajaxRequester.get(url, userData, credential.getHeaders())
        };

        User.prototype.register = function(userData) {
            var url = this._baseUrl + 'users';
            return this._ajaxRequester.post(url, JSON.stringify(userData), credential.getHeaders())
        };

        User.prototype.getUserData = function() {
            return JSON.parse(credential.getUserData());
        };

        User.prototype.setUserData = function(userData) {
             credential.setUserData(JSON.stringify(userData));
        };

        User.prototype.logout = function() {
            return credential.deleteUser();
        };

        return User;
    })();

    var Products = (function() {

        function Products (baseUrl, ajaxRequest) {
            this._baseUrl = baseUrl;
            this._ajaxRequester = ajaxRequest;
        }

        Products.prototype.getAllProducts = function (data) {

            var url = this._baseUrl + 'classes/Product';
            return this._ajaxRequester.get(url, data, credential.getHeaders())
        };

        return Products;
    })();


    return {
        data: function(baseUrl, ajaxRequest) {
            return new Data(baseUrl, ajaxRequest);
        }
    }

})();