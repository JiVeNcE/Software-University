var app = app || {};

app.userView = (function(){
    function UserView() {
        this.loginView= {
            load: loadLoginView
        };
        this.registerView = {
            load: loadRegisterView
        }
    }


    function loadLoginView(selector) {
        $.get('templates/login.html', function(template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);

        }).then(function() {

            $("#login-button").click(function(){

                var username = $("#username").val();
                var password = $("#password").val();

                $.sammy(function() {
                    this.trigger('login', {username: username, password: password});
                })

            })
        })
    }

    function loadRegisterView(selector) {
        $.get('templates/register.html', function(template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);
        }).then(function() {

            $("#register-button").click(function(){
                var username = $("#username").val();
                var password = $("#password").val();
                var confirmPassword = $("#confirm-password").val();

                if(confirmPassword != password) {
                    noty({
                        theme: 'relax',
                        text: "Password does not match the confirm password",
                        type: 'error',
                        timeout: 2000,
                        closeWith: ['click']
                    });

                }else {
                    $.sammy(function() {
                        this.trigger('register', {username: username, password: password});
                    })
                }

            })
        })
    }


    return {
        load: function() {
            return new UserView();
        }
    }
}());



