var app = app || {};

app.lectureView = (function() {
    function LectureView() {
        this.allLectureView = {
            load: loadAllLectureView
        };

        this.userLecturesView = {
            load: loadUserLecturesView
        };

        this.addLecture = {
            load: loadAddLectureView
        };

        this.editLecture = {
            load: loadEditLectureView
        };

        this.deleteLecture = {
            load: loadDeleteLectureView
        };
    }

    function loadUserLecturesView(selector, data) {
        $.get('templates/calendar.html', function(template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);

           initCalendar(data);
        })
    }


    function loadAllLectureView(selector, data) {
        $.get('templates/calendar.html', function(template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);

            initCalendar(data);
        })
    }

    function loadAddLectureView(selector, data) {

        $.get('templates/add-lecture.html', function(template) {
            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);

        }).then(function() {

            $("#addLecture").click(function(){
                var title = $("#title").val();
                var start = $("#start").val();
                var end = $("#end").val();


                $.sammy(function() {
                    this.trigger('add-lecture', {title: title, start: start,  end: end});
                })

            })
        })
    }

    function loadEditLectureView(selector, data) {

        $.get('templates/edit-lecture.html', function(template) {
            window.location.replace('#/calendar/edit/');
            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);

        }).then(function() {

            $("#editLecture").click(function(){
                var title = $("#title").val();
                var start = $("#start").val();
                var end = $("#end").val();
                var lectureId = $(this).attr("data-id");


                $.sammy(function() {
                    this.trigger('edit-lecture', {title: title, start: start,  end: end, lectureId: lectureId});
                })

            })
        })
    }

    function loadDeleteLectureView(selector, data) {

        $.get('templates/delete-lecture.html', function(template) {
            window.location.replace('#/calendar/delete/');
            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);

        }).then(function() {

            $("#deleteLecture").click(function(){
                var lectureId = $(this).attr("data-id");

                $.sammy(function() {
                    this.trigger('delete-lecture', lectureId);
                })

            })
        })
    }

    function initCalendar(data) {
        $("#calendar").fullCalendar({
            theme: false,
            header: {
                left: 'prev,next today addEvent',
                center: 'title',
                right: 'month,agendaWeek,agendaDay'
            },
            defaultDate: '2016-01-12',
            selectable: false,
            editable: false,
            eventLimit: true,
            events: data,
            customButtons: {
                addEvent: {
                    text: 'Add Event',
                    click: function () {
                        Sammy(function() {
                            this.trigger('redirectUrl', {url: '#/add-lecture/'});
                        });
                    }
                }
            },
            eventClick: function (calEvent, jsEvent, view) {


                    if(window.location.hash == "#/calendar/list/") {
                        $('#editLecture').hide();
                        $('#deleteLecture').hide();
                    }



                $.get('templates/modal.html', function (templ) {
                    var rendered = Mustache.render(templ, calEvent);
                    $('#modal-body').html(rendered);
                    var lectureData = {title: calEvent.title, start: calEvent._start._d, end: calEvent._end._d, lecturer: calEvent.lecturer, id: calEvent._id};
                    $('#editLecture').on('click', function() {
                        $('#events-modal').on('hidden.bs.modal', function() {
                            Sammy(function() {
                                this.trigger('show-edit-lecture', lectureData);
                            });
                        });

                    });
                    $('#deleteLecture').on('click', function() {
                        $('#events-modal').on('hidden.bs.modal', function() {
                            Sammy(function() {
                                this.trigger('show-delete-lecture', lectureData);
                            });
                        });

                    });


                });
                $('#events-modal').modal();
            }
        });
    }

    return {
        load: function() {
            return new LectureView();
        }
    }

}());
