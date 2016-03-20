var app = app  || {};

app.ajaxRequester = (function() {
    function AjaxRequester(appId, appSecret) {
        this.appId = appId;
        this.appSecter = appSecret;
        this.baseUrl = 'https://baas.kinvey.com/';
    }

    AjaxRequester.prototype.makeRequester = function(method, url, data, userSession) {

        var token,
            _this = this,
            deffer = Q.defer(),
            options = {
                method: method,
                url: url,
                success: function(data) {
                    deffer.resolve(data);
                },
                error : function(data) {
                    deffer.reject(data);
                }
            };

        $.ajaxSetup({
            beforeSend : function(xhr, settings) {
                if (!userSession) {
                    token = _this.appId + ':' + _this.appSecter;
                    xhr.setRequestHeader('Authorization', 'Basic ' + btoa(token));
                } else {
                    token = sessionStorage['sessionAuth'];
                    xhr.setRequestHeader('Authorization', 'Kinvey ' + token);
                }
                if(data) {
                    xhr.setRequestHeader('Content-Type', 'application/json');
                    settings.data = JSON.stringify(data);
                    return true;
                }
            }
        });

        $.ajax(options);

        return deffer.promise;
    };

    return {
        config: function(appId, appSecret) {
            app.ajaxRequester = new AjaxRequester(appId, appSecret);
        }
    }

}());

