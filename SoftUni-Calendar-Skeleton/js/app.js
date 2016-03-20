var app = app || {};

(function() {

    app.ajaxRequester.config('kid_-J9f7pV6k-', '9b98f0783fa247d18fc3313608fc91e7');

    var userViewBag = app.userView.load();
    var userModel = app.userModel.load();

    var userController = app.userController.load(userViewBag, userModel);

    var homeViewBag = app.homeView.load();
    var homeController = app.homeController.load(homeViewBag);


    var lectureViewBag = app.lectureView.load();
    var lectureModel = app.lectureModel.load();

    var lectureController = app.lectureController.load(lectureViewBag, lectureModel);






    app.router = Sammy(function() {
        var selector = '#container';
        var menuSelector = '#menu';

        this.before(function() {
            var userId = sessionStorage['userId'];
            if(userId) {
                homeController.loadHomeMenu(menuSelector);
            }else {

                homeController.loadGuestMenu(menuSelector);
            }
        });

        this.before({except: {path: '#\/(register\/|login\/)?'}}, function() {
            var userId = sessionStorage['userId'];
            if(!userId) {
                noty({
                    theme: 'relax',
                    text: 'You should be logged in to do this action!',
                    type:'error',
                    timeout: 2000,
                    closeWith: ['click']
                });
                this.redirect('#/');
                return false;
            }
        });

        this.get('#/', function() {
            homeController.loadWelcomeGuest(selector);
        });

        this.get('#/login/', function() {
            userController.loadLoginView(selector);
        });

        this.get('#/register/', function() {
            userController.loadRegisterView(selector);
        });

        this.get('#/home/', function() {
            homeController.loadWelcomeUser(selector);
        });

        this.get('#/logout/', function() {
            userController.logout();
        });

        this.get('#/calendar/list/', function() {
            lectureController.loadAllLectures(selector);
        });

        this.get('#/calendar/my/', function() {
            lectureController.loadUserLectures(selector);
        });

        this.get('#/add-lecture/', function() {
            lectureController.loadAddLecture(selector);
        });

        this.get('#/calendar/edit/', function() {

        });

        this.get('#/calendar/delete/', function() {

        });


        this.bind('login', function(e, data) {
            userController.login(data);
        });

        this.bind('register', function(e, data) {
            userController.register(data);
        });

        this.bind('redirectUrl', function(e, data) {
            this.redirect(data.url);
        });

        this.bind('add-lecture', function(e, data) {
            lectureController.addLecture(data);
        });

        this.bind('show-edit-lecture', function(e, data) {
            lectureController.loadEditLecture(selector, data);
        });

        this.bind('show-delete-lecture', function(e, data) {
            lectureController.loadDeleteLecture(selector, data);
        });

        this.bind('edit-lecture', function(e, data) {
            lectureController.editLecture(data);
        });

        this.bind('delete-lecture', function(e, data) {
            lectureController.deleteLecture(data);
        });


    });

    app.router.run('#/');



}());

