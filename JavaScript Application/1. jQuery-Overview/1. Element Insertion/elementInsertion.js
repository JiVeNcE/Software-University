/**
 * Created by Zhivko on 18.11.2014 г..
 */
(function($) {

    var $wrapper,
        $list,
        $listLi,
        $addButtonBefore,
        $addButtonAfter;

    function onBeforeButtonClick(ev) {
        $('#listId').prepend(
            $('<li />')
                .html('New element before!')
        );
    }

    function onAfterButtonClick(ev) {
        $('#listId').append(
            $('<li />')
                .html('New element after!')

        );
    }

    $wrapper = $("#wrapper");

    $addButtonBefore = $('<input>').attr('type', 'button').attr('value', 'Add element').on('click', onBeforeButtonClick);

    $addButtonAfter = $('<input>').attr('type', 'button').attr('value', 'Add element').on('click', onAfterButtonClick);

    $list = $('<ul/>').attr("id", 'listId');
    $listLi = $('<li>');

    $list.append($listLi.text('Element'));


    $wrapper.append($addButtonBefore);
    $wrapper.append($list);
    $wrapper.append($addButtonAfter);

    $wrapper.prepend("<h1>Elements</h1>");
}(jQuery));