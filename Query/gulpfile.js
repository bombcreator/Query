var gulp = require("gulp");
var merge = require("merge-stream");

var deps = {
  jquery: {
    "dist/*": ""
  },
  bootstrap: {
    "dist/**/*": ""
  }
};

gulp.task("scripts", function() {
  var streams = [];
  for (var prop in deps) {
    console.log("prepping scripts for " + prop);
    for (var itemProp in deps[prop]) {
      streams.push(
        gulp
          .src("node_modules/" + prop + "/" + itemProp)
          .pipe(gulp.dest("wwwroot/lib/" + prop + "/" + deps[prop][itemProp]))
      );
    }
  }
  return merge(streams);
});

gulp.task("default", ["scripts"]);
