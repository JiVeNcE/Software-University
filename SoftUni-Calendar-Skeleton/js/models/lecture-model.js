var app = app || {};

app.lectureModel = (function() {
    function LectureModel() {
        this.serviceUrl = app.ajaxRequester.baseUrl + 'appdata/' + app.ajaxRequester.appId;
    }


    LectureModel.prototype.loadLecturesData = function() {
        var requestUrl = this.serviceUrl + '/lectures';
        return app.ajaxRequester.makeRequester("GET", requestUrl, null, true);
    };

    LectureModel.prototype.loadUserLecturesData = function(userId) {
        var requestUrl = this.serviceUrl + '/lectures?query={"_acl.creator":"'+ userId + '"}';
        return app.ajaxRequester.makeRequester("GET", requestUrl, null, true);
    };

    LectureModel.prototype.addLecture = function(data) {
        var requestUrl = this.serviceUrl + '/lectures';
        return app.ajaxRequester.makeRequester("POST", requestUrl, data, true);
    };

    LectureModel.prototype.editLecture = function(data, lectureId) {
        var requestUrl = this.serviceUrl + '/lectures/' + lectureId;
        return app.ajaxRequester.makeRequester("PUT", requestUrl, data, true);
    };

    LectureModel.prototype.deleteLecture = function(lectureId) {
        var requestUrl = this.serviceUrl + '/lectures/' + lectureId;
        return app.ajaxRequester.makeRequester("DELETE", requestUrl, null, true);
    };

    return {
        load: function() {
            return new LectureModel();
        }
    }

}());
