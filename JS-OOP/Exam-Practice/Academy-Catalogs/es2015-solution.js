/* jshint esversion: 6 */
/* globals console */

function solve() {
    "use strict";

    class Validator {
        static validateStringRange(str, min, max) {
            let isInvalid = typeof (str) !== "string" ||
                str.length < min ||
                str.length > max;

            if (isInvalid) {
                throw new Error("Invalid string");
            }
        }

        static validateNumber(num, min, max) {
            let isInvalid = typeof (num) !== "number" ||
                num < min ||
                num > max;

            if (isInvalid) {
                throw new Error("Invalid number");
            }
        }

        static validateParsableString(str) {
            if (isNaN(str)) {
                throw new Error("String is not a number");
            }
        }

        static validateArrNotEmpty(arr) {
            if (arr.length < 1) {
                throw new Error("Array is empty");
            }
        }

        static validateArrItemsType(arr, parent) {
            if (!arr.every(x => x instanceof parent)) {
                throw new Error(`Not every item in the array is instanceof '${parent.name}'`);
            }
        }
    }

    let createArrayFromArguments = function (item, args) {
        return Array.isArray(item) ?
            item :
            Array.from(args);
    };

    let Item = (function () {
        let lastId = 0;

        return class Item {
            constructor(name, description) {
                this.id = ++lastId;
                this.name = name;
                this.description = description;
            }

            // name
            get name() {
                return this._name;
            }

            set name(val) {
                Validator.validateStringRange(val, 2, 40);
                this._name = val;
            }

            // description
            get description() {
                return this._description;
            }

            set description(val) {
                Validator.validateStringRange(val, 1, Number.MAX_VALUE);
                this._description = val;
            }
        };
    } ());

    let Book = (function () {
        return class Book extends Item {
            constructor(name, description, isbn, genre) {
                super(name, description);
                this.isbn = isbn;
                this.genre = genre;
            }

            // isbn
            get isbn() {
                return this._isbn;
            }

            set isbn(val) {
                Validator.validateParsableString(val);

                if (val.length !== 10 && val.length !== 13) {
                    throw new Error("Invalid isbn");
                }

                this._isbn = val;
            }

            // genre
            get genre() {
                return this._genre;
            }

            set genre(val) {
                Validator.validateStringRange(val, 2, 20);
                this._genre = val;
            }
        };
    } ());

    let Media = (function () {
        return class Media extends Item {
            constructor(name, description, duration, rating) {
                super(name, description);
                this.duration = duration;
                this.rating = rating;
            }

            // duration
            get duration() {
                return this._duration;
            }

            set duration(val) {
                Validator.validateNumber(val, 0, Number.MAX_VALUE);
                this._duration = val;
            }

            // rating
            get rating() {
                return this._rating;
            }

            set rating(val) {
                Validator.validateNumber(val, 1, 5);
                this._rating = val;
            }
        };
    } ());

    let Catalog = (function () {
        let _lastId = 0;

        return class Catalog {
            constructor(name) {
                this.id = ++_lastId;
                this.name = name;
                this.items = [];
            }

            // name
            get name() {
                return this._name;
            }

            set name(val) {
                Validator.validateStringRange(val, 2, 40);
                this._name = val;
            }

            // methods
            add(item) {
                let currentItems = createArrayFromArguments(item, arguments);
                Validator.validateArrNotEmpty(currentItems);
                Validator.validateArrItemsType(currentItems, Item);

                this.items = this.items.concat(currentItems);

                return this;
            }

            find(arg) {
                if (typeof arg === "number") {
                    let result = this.items.find(x => x.id === arg);

                    return result || null;

                } else if (typeof arg === "object") {
                    let result = this.items
                        .filter(x => x._name === arg.name || x.id === arg.id);

                    return result;

                } else {
                    throw new Error("Invalid argument");
                }
            }

            search(pattern) {
                let patternLowerCase = pattern.toLowerCase();
                let result = this.items.filter(item => {

                    return item._name.toLowerCase().indexOf(patternLowerCase) !== -1 ||
                        item._description.toLowerCase().indexOf(patternLowerCase) !== -1;
                });

                return result;
            }
        };
    } ());

    let BookCatalog = (function () {
        return class BookCatalog extends Catalog {
            constructor(name) {
                super(name);
            }

            add(item) {
                let currentItems = createArrayFromArguments(item, arguments);
                Validator.validateArrNotEmpty(currentItems);
                Validator.validateArrItemsType(currentItems, Book);

                super.add(currentItems);
            }

            getGenres() {
                let uniqueGenres = new Set();

                this.items.forEach(x => uniqueGenres.add(x._genre.toLowerCase()));

                return Array.from(uniqueGenres);
            }

            find(options) {
                let result = super.find(options);

                return result.filter(x => x._genre === options.genre);
            }
        };
    } ());

    let MediaCatalog = (function () {
        return class MediaCatalog extends Catalog {
            constructor(name) {
                super(name);
            }

            add(item) {
                let currentItems = createArrayFromArguments(item, arguments);
                Validator.validateArrNotEmpty(currentItems);
                Validator.validateArrItemsType(currentItems, Media);

                super.add(currentItems);
            }

            getTop(count) {
                Validator.validateNumber(count, 1, Number.MAX_VALUE);

                let sorted = this.items
                    .slice()
                    .sort((x, y) => y._rating - x._rating)
                    .slice(0, count);

                let result = sorted
                    .map(x => {
                        return {
                            id: x.id,
                            name: x._name
                        };
                    });

                return result;
            }

            getSortedByDuration() {
                let sorted = this.items
                    .slice()
                    .sort((x, y) => {
                        if (x._duration === y._duration) {
                            return y.id - x.id;
                        }

                        return y._duration - x._duration;
                    });

                return sorted;
            }
        };
    } ());

    return {
        getBook: function (name, isbn, genre, description) {
            //return a book instance
            return new Book(name, description, isbn, genre);
        },
        getMedia: function (name, rating, duration, description) {
            //return a media instance
            return new Media(name, description, duration, rating);
        },
        getBookCatalog: function (name) {
            //return a book catalog instance
            return new BookCatalog(name);
        },
        getMediaCatalog: function (name) {
            //return a media catalog instance
            return new MediaCatalog(name);
        }
    };
}


// let newMedia = new Media("someName", "asdfasf", 4, 4);
// let mediaOne = new Book("someName", "someASDFsdf", "1111111111", "asdfasf");
// let mediaTwo = new Book("somenaem", "asdfasf", "1111111111111", "sci-fi");
// let mediaThree = new Book("somenaem", "asdfasf", "1111111111111", "sCi-fi");

// let obj = {};
// let newCatalog = new Catalog("someCatalog");


// newCatalog.add(newMedia, mediaOne);
// // console.log(newCatalog);

// let found = newCatalog.find({ id: 8, name: "somee" });
// console.log("***************************");
// console.log(found);


// let newBookCatalog = new BookCatalog("bookcatalog");
// newBookCatalog.add([mediaOne, mediaTwo, mediaThree]);
// console.log(newBookCatalog);

// console.log(newBookCatalog.getGenres());

// let newMediaCatalog = new MediaCatalog("asdfasd");
// let mOne = new Media("4asdfasf", "asdfas", 3, 4);
// let mTwo = new Media("1asdf", "asdfas", 6, 1);
// let mThree = new Media("3asdf", "asdfas", 2, 3);
// let mFour = new Media("5asdf", "asdfas", 8, 5);

// newMediaCatalog.add(mOne, mTwo, mThree, mFour);

// let top = newMediaCatalog.getTop(4);
// console.log(top);
// let durationSort = newMediaCatalog.getSortedByDuration();
// console.log(durationSort);

// // let search = newCatalog.search("fff");
// // console.log(search);

// // let find = newCatalog.find(5);

// // console.log(find);





// let arr = [1, 41, 5, 6, 23];

// arr.sort();
// console.log(arr);

