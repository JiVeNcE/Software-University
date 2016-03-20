
var app = app || {};

app.userController = (function() {
    function UserController(viewBag, userModel) {
        this._viewBag = viewBag;
        this._userModel = userModel;
    }

    UserController.prototype.loadLoginView = function(selector) {
        this._viewBag.loginView.load(selector);
    };

    UserController.prototype.loadRegisterView = function(selector) {
        this._viewBag.registerView.load(selector);
    };


    UserController.prototype.login = function(data) {

        this._userModel.signIn(data).then(function(success) {
            sessionStorage['sessionAuth'] = success._kmd.authtoken;
            sessionStorage['username'] = success.username;
            sessionStorage['fullname'] = success.fullname;
            sessionStorage['userId'] = success._id;

            Sammy(function() {
                this.trigger('redirectUrl', {url: '#/home/'});
            });

            noty({
                theme: 'relax',
                text: 'You have successfully logged in!',
                type: 'success',
                timeout: 2000,
                closeWith: ['click']
            });

        },function(err) {
            noty({
                theme: 'relax',
                text: err.responseJSON.error || 'A problem occurred while signing in!',
                type: 'error',
                timeout: 2000,
                closeWith: ['click']
            });
        }).done();
    };


    UserController.prototype.register = function(data) {

        this._userModel.signUp(data).then(function(success) {
            sessionStorage['sessionAuth'] = success._kmd.authtoken;
            sessionStorage['username'] = success.username;
            sessionStorage['fullname'] = success.fullname;
            sessionStorage['userId'] = success._id;

            Sammy(function() {
                this.trigger('redirectUrl', {url: '#/home/'});
            });

            noty({
                theme: 'relax',
                text: 'You have successfully registered!',
                type: 'success',
                timeout: 2000,
                closeWith: ['click']
            });

        },function(err) {
            noty({
                theme: 'relax',
                text: err.responseJSON.error || 'A problem occurred while trying to register!',
                type: 'error',
                timeout: 2000,
                closeWith: ['click']
            });
        }).done();
    };


    UserController.prototype.logout = function() {

        this._userModel.logOut().then(function() {
            sessionStorage.removeItem('sessionAuth');
            sessionStorage.removeItem('username');
            sessionStorage.removeItem('fullname');
            sessionStorage.removeItem('userId');

            Sammy(function() {
                this.trigger('redirectUrl', {url: '#/'});
            });

            noty({
                theme: 'relax',
                text: 'You have successfully logged out!',
                type: 'success',
                timeout: 2000,
                closeWith: ['click']
            });


        },function(err) {
            noty({
                theme: 'relax',
                text: err.responseJSON.error || 'A problem occurred while signing out!',
                type: 'error',
                timeout: 2000,
                closeWith: ['click']
            });
        }).done();
    };


    return {
        load: function(viewBag, userModel) {
            return new UserController(viewBag, userModel)
        }
    }
}());