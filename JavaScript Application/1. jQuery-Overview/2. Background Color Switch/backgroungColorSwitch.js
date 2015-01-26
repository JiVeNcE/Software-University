/**
 * Created by Zhivko on 18.11.2014 г..
 */

(function($) {

    var $wrapper,
        $classField,
        $colorfield,
        $buttonPaint,
        $labelField,
        $labelColor,
        liClass;


    $wrapper = $('#wrapper');

    $classField = $('<input>').attr('type', 'text').addClass('class-field');
    $labelField = $('<label>').text('Class:');

    $colorfield = $('<input>').attr('type', 'color').addClass('color-field');
    $labelColor = $('<label>').text('Color:');


    $buttonPaint = $('<input>').attr('type', 'button').attr('value', 'Paint').addClass('button-paint').on('click', onButtonPaint);


    function onButtonPaint(ev) {
        $('li').each(function () {
            liClass = $(this).attr('class');
            if ( liClass == $classField.val()) {
                $(this).css("background-color", $colorfield.val());
            }
        });
    }

    $wrapper.append($labelField);
    $wrapper.append($classField);
    $wrapper.append($labelColor);
    $wrapper.append($colorfield);
    $wrapper.append($buttonPaint);


}(jQuery));