var app = app || {};

app.lectureController = (function() {

    function LectureController(viewBag, lectureModel) {
        this._viewBag = viewBag;
        this._lectureModel = lectureModel;
    }

    LectureController.prototype.loadAllLectures = function(selector) {

        var _this = this;

        this._lectureModel.loadLecturesData().then(function(data) {


            _this._viewBag.allLectureView.load(selector, data);


        },function(err) {
            noty({
                theme: 'relax',
                text: err.responseJSON.error || "A problem occurred while trying to get all Lectures",
                type: 'error',
                timeout: 2000,
                closeWith: ['click']
            });
        }).done();
    };

    LectureController.prototype.loadUserLectures = function(selector) {

        var _this = this;

        var userId = sessionStorage['userId'];

        this._lectureModel.loadUserLecturesData(userId).then(function(data) {


            _this._viewBag.userLecturesView.load(selector, data);


        },function(err) {
            noty({
                theme: 'relax',
                text: err.responseJSON.error || "A problem occurred while trying to get your Lectures",
                type: 'error',
                timeout: 2000,
                closeWith: ['click']
            });
        }).done();
    };

    LectureController.prototype.loadAddLecture = function(selector) {
        this._viewBag.addLecture.load(selector);
    };

    LectureController.prototype.addLecture = function(data) {
        var result = {
            title: data.title,
            start: data.start,
            end: data.end,
            lecturer:  sessionStorage['username']

        };

        this._lectureModel.addLecture(result).then(function() {

            Sammy(function() {
                this.trigger('redirectUrl', {url: '#/calendar/list/'});
            });

        },function(err) {
            noty({
                theme: 'relax',
                text: err.responseJSON.error || "A problem occurred while trying Add Lecture",
                type: 'error',
                timeout: 2000,
                closeWith: ['click']
            });
        }).done();
    };

    LectureController.prototype.loadEditLecture = function(selector, data) {
        this._viewBag.editLecture.load(selector, data);
    };

    LectureController.prototype.loadDeleteLecture = function(selector, data) {
        this._viewBag.deleteLecture.load(selector, data);
    };

    LectureController.prototype.editLecture = function(data) {
        var result = {
            title: data.title,
            start: data.start,
            end: data.end,
            lecturer:  sessionStorage['username']
        };

        this._lectureModel.editLecture(result, data.lectureId).then(function() {

            Sammy(function() {
                this.trigger('redirectUrl', {url: '#/calendar/list/'});
            });

        },function(err) {
            noty({
                theme: 'relax',
                text: err.responseJSON.error || "A problem occurred while trying Edit Lecture",
                type: 'error',
                timeout: 2000,
                closeWith: ['click']
            });
        }).done();
    };

    LectureController.prototype.deleteLecture = function(lectureId) {


        this._lectureModel.deleteLecture(lectureId).then(function() {

            Sammy(function() {
                this.trigger('redirectUrl', {url: '#/calendar/list/'});
            });

        },function(err) {
            noty({
                theme: 'relax',
                text: err.responseJSON.error || "A problem occurred while trying Delete Lecture",
                type: 'error',
                timeout: 2000,
                closeWith: ['click']
            });
        }).done();
    };


    return {
        load: function(viewBag, lectureModel) {
            return new LectureController(viewBag, lectureModel);
        }
    }

}());


