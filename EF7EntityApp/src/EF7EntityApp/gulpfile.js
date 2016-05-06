/// <binding AfterBuild='angular2' />
var gulp = require('gulp');
var paths = {};
paths.webroot = "wwwroot/";

gulp.task("angular2:moveLibs", function () {
    return gulp.src([
        'node_modules/angular2/bundles/js',
        'node_modules/angular2/bundles/angular2.*.js*',
        'node_modules/angular2/bundles/angular2-polyfills.js',
        'node_modules/angular2/bundles/http.*.js*',
        'node_modules/angular2/bundles/router.*.js*',
        'node_modules/es6-shim/es6-shim.min.js*',
        'node_modules/angular2/es6/dev/src/testing/shims_for_IE.js',
        'node_modules/systemjs/dist/*.*',
        'node_modules/rxjs/bundles/Rx.js'
    ])
        .pipe(gulp.dest(paths.webroot + "Angular"));

});

gulp.task("angular2:moveJs", function () {
    return gulp.src(["Angular/**/*.js"])
        .pipe(gulp.dest(paths.webroot + "Angular/app/"));

});
gulp.task("angular2", ["angular2:moveLibs", "angular2:moveJs"])