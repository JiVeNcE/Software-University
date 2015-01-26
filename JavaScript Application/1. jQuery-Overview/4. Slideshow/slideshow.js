/**
 * Created by Zhivko on 19.11.2014 г..
 */
'use strict';

(function($) {

    var width = 700;
    var animationSpeed = 1000;
    var pause = 5000;
    var currentSlide = 1;

    var $slider = $('#slider');
    var $slideContainer = $slider.find('.slides');
    var $slides = $slideContainer.find('.slide');




    var interval;
    function startSlider() {
        interval = setInterval(function () {
            $slideContainer.animate({'margin-left': '-=' + width}, animationSpeed, function () {

                if (++currentSlide === $slides.length) {
                    currentSlide = 1;
                    $slideContainer.css('margin-left', 0)
                }
            });
        }, pause);
    }


    $('#rightArrow').click(function () {
        interval = setTimeout(function () {
        $slideContainer.animate({'margin-left': '-=' + width}, animationSpeed, function () {

            if (currentSlide < $slides.length - 1) {
                currentSlide++;
            }else {
                currentSlide = 0;
            }
        });
        }, 100);
    });

    $('#leftArrow').click(function () {
        interval = setTimeout(function () {
            $slideContainer.animate({'margin-left': '-=' - width}, animationSpeed, function () {

                if (currentSlide < 0) {
                    currentSlide--;
                }else {
                    currentSlide = $slides.length - 1;
                }
            });
        }, 100);
    });



    startSlider();

}(jQuery));