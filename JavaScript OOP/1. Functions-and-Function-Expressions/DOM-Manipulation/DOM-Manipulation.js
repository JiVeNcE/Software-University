/**
 * Created by Zhivko on 30.10.2014 г..
 */
var domModule = function() {

    var element,
        appendTo,
        from,
        removeElement,
        event,
        expression,
        i;

    function appendChild() {
         element = arguments[0];
         appendTo = document.querySelector(arguments[1]);

        appendTo.appendChild(element);
    }

    function removeChild() {
         from = document.querySelector(arguments[0]);
         removeElement = from.querySelector((arguments[1]));

        from.removeChild(removeElement);
    }

    function addHandler() {
         element = document.querySelector(arguments[0]);
         event = arguments[1];
         expression = arguments[2];

        for(i = 0; i < element.length; i++){
            element[i].addEventListener(event, expression);
        }
    }

    function retrieveElements() {
        element = document.querySelectorAll(arguments[0]);
        return element;
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    };
}();

