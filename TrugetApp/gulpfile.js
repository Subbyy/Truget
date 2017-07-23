/// <binding BeforeBuild='sass' ProjectOpened='watch' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require("gulp"),
    fs = require("fs"),
    less = require("gulp-less"),
    sass = require("gulp-sass");

// other content removed
var root = "./wwwroot/";
var paths = {
    scss: root + "sass/**/*.scss",
    materialize: root + "lib/materialize/sass/**/*.scss",
    materializeDest: root + "lib/materialize/css/",
    scssDest: root + "css/materialize.css"
};
gulp.task('sass', function () {
    return gulp.src(paths.scss)
        .pipe(sass())
        .pipe(gulp.dest(paths.scssDest));
});

gulp.task('materialize', function () {
    return gulp.src(paths.materialize)
        .pipe(sass())
        .pipe(gulp.dest(paths.materializeDest));
});

gulp.task('watch', function () {
    return gulp.watch(paths.scss, ['sass'])
        .watch(paths.materialize, ['materialize']);
});