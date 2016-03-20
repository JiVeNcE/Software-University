var app = app || {};

app.userModel = (function() {
    function UserModel() {
        this.serviceUrl = app.ajaxRequester.baseUrl + 'user/' + app.ajaxRequester.appId;
    }



    UserModel.prototype.signUp = function(data) {
        var requestUrl = this.serviceUrl;
        return app.ajaxRequester.makeRequester("POST", requestUrl, data, false);
    };

    UserModel.prototype.signIn = function(data) {
        var requestUrl = this.serviceUrl + "/login";
        return app.ajaxRequester.makeRequester("POST", requestUrl, data, false);
    };

    UserModel.prototype.logOut = function() {
        var requestUrl = this.serviceUrl + "/_logout";
        return app.ajaxRequester.makeRequester("POST", requestUrl, null, true);
    };

    return {
        load: function() {
            return new UserModel();
        }
    };

}());

