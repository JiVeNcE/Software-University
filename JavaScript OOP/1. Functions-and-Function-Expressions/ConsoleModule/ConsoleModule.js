/**
 * Created by Zhivko on 30.10.2014 г..
 */

var specialConsole = function () {

    var message,
        args,
        i;

    function writeLine() {

        message = arguments[0];
        if (arguments.length === 1) {
            writeConsole(message.toString());
        } else if (arguments.length > 1) {
            args = Array.prototype.slice.call(arguments);
            message = fillPlaceholders(message, args.slice(1, args.length));
            writeConsole(message.toString());
        }
    }

        function fillPlaceholders(str, args) {
            for (i = 0; i < args.length; i++) {
                str = str.replace('{' + i + '}', args[i].toString());
            }
            return str;
        }

        function writeConsole(str) {
            console.log(str.toString());
        }

    return {
        writeLine: writeLine,
        writeError: writeLine,
        writeWarning: writeLine
    };

}();

specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0}", "hello");
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");


