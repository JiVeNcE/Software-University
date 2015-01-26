/**
 * Created by Zhivko on 30.10.2014 г..
 */

var Shapes = (function () {
    var Shape = (function () {

        function Shape(x, y, colors) {
            this._x = x;
            this._y = y;
            this._colors = colors;
        }

        Shape.prototype = {
            serialize: function () {
                var serializedShape = {
                    x: this._x,
                    y: this._y,
                    colors: this._colors
                };
                return serializedShape;
            },
            canvas: function () {
                var canvas = {
                    element: document.getElementById("shapesContainer").getContext("2d")
                };
                return canvas;
            }
        };

        Shape.prototype.toString = function () {
            return this.serialize();
        };

        return Shape;
    }());

    var Circle = (function () {
        function Circle(x, y, colors, radius) {
            Shape.call(this, x, y, colors);
            this._radius = radius;
        }

        Circle.prototype = new Shape();

        Circle.prototype.serialize = function () {
            var serializeCircle = Shape.prototype.serialize.call(this);
            serializeCircle.radius = this._radius;
            return serializeCircle;
        };

        Circle.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.arc(this.serialize().x, this.serialize().y, this.serialize().radius, 0, 2 * Math.PI, false);
            this.canvas().element.fillStyle = this.serialize().color;
            this.canvas().element.stroke();
            //this.canvas().element.fill();
        };

        Circle.prototype.toString = function () {
            return "Circle: " + JSON.stringify(this.serialize());
        };

        return Circle;
    }());

    var Rect = (function () {
        function Rect(x, y, colors, width, height) {
            Shape.call(this, x, y, colors);
            this._width = width;
            this._height = height;
        }

        Rect.prototype = new Shape();

        Rect.prototype.serialize = function () {
            var serializeRectangle = Shape.prototype.serialize.call(this);
            serializeRectangle.width = this._width;
            serializeRectangle.height = this._height;
            return serializeRectangle;
        };

        Rect.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.fillStyle = this.serialize().color;
            this.canvas().element.fillRect(this.serialize().x,
                this.serialize().y, this.serialize().width, this.serialize().height);
        };

        Rect.prototype.toString = function () {
            return "Rectangle: " + JSON.stringify(this.serialize());
        };
        return Rect;
    }());

    var Triangle = (function () {
        function Triangle(x, y, colors, x2, y2, x3, y3) {
            Shape.call(this, x, y, colors);
            this._x2 = x2;
            this._y2 = y2;
            this._x3 = x3;
            this._y3 = y3;
        }

        Triangle.prototype = new Shape();

        Triangle.prototype.serialize = function () {
            var serializeTriangle = Shape.prototype.serialize.call(this);
            serializeTriangle.x2 = this._x2;
            serializeTriangle.y2 = this._y2;
            serializeTriangle.x3 = this._x3;
            serializeTriangle.y3 = this._y3;
            return serializeTriangle;
        };

        Triangle.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.fillStyle = this.serialize().color;
            this.canvas().element.moveTo(this.serialize().x2, this.serialize().y2);
            this.canvas().element.lineTo(this.serialize().x3, this.serialize().x3);
            this.canvas().element.lineTo(this.serialize().y3 ,this.serialize().y2);
            this.canvas().element.fill();
            this.canvas().element.stroke();
        };

        Triangle.prototype.toString = function () {
            return "Triangle: " + JSON.stringify(this.serialize());
        };

        return Triangle;
    }());

    var Segment = (function () {
        function Segment(x, y, colors, x2, y2) {
            Shape.call(this, x, y, colors);
            this._x2 = x2;
            this._y2 = y2;
        }

        Segment.prototype = new Shape();

        Segment.prototype.serialize = function () {
            var serializeSegment = Shape.prototype.serialize.call(this);
            serializeSegment.x2 = this._x2;
            serializeSegment.y2 = this._y2;
            return serializeSegment;
        };

          Segment.prototype.draw = function () {
          this.canvas().element.beginPath();
          this.canvas().element.fillStyle = this.serialize().colors;
          this.canvas().element.moveTo(0, 0);
          this.canvas().element.lineTo(this.serialize().x2, this.serialize().y2);
          this.canvas().element.fill();
          this.canvas().element.stroke();

        };

        Segment.prototype.toString = function () {
            return "Segment: " + JSON.stringify(this.serialize());
        };
        return Segment;
    }());

    var Point = (function () {
        function Point(x, y, colors) {
            Shape.call(this, x, y, colors);
        }

        Point.prototype = new Shape();

        Point.prototype.serialize = function () {
            var serializePoint = Shape.prototype.serialize.call(this);
            return serializePoint;
        };
        Point.prototype.draw = function () {
            this.canvas().element.beginPath();
            this.canvas().element.fillStyle = this.serialize().color;
            this.canvas().element.fillRect(this.serialize().x, this.serialize().y, 5, 5);
        };

        Point.prototype.toString = function () {
            return "Point: " + JSON.stringify(this.serialize());
        };

        return Point;
    }());

    return {
        Shape: Shape,
        Circle: Circle,
        Rect: Rect,
        Triangle: Triangle,
        Segment: Segment,
        Point: Point
    }
}());

var circle = new Shapes.Circle(10, 28, "red", 4);
console.log(circle.toString());

var point = new Shapes.Point(1, 2, "red");
console.log(point.toString());

var triangle = new Shapes.Triangle(3, 5, "black",100, 200, 90, 20);
console.log(triangle.toString());

var rect = new Shapes.Rect(15, 70, "red", 100, 50);
console.log(rect.toString());

var segment = new Shapes.Segment(10, 5, "blue", 120, 30);
console.log(segment.toString());