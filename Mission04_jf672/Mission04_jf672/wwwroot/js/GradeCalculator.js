$('#btnCalc').click(function () {

    /*get variables from form */
    var assign = $('#assign').val()
    var group = $('#group').val()
    var quiz = $('#quiz').val()
    var midterm = $('#midterm').val()
    var final = $('#final').val()
    var intex = $('#intex').val()

    /* calculate weighted average */
    var overallGrade = Math.round(((assign * .5) + (group * .1) + (quiz * .1) + (midterm * .1) + (final * .1) + (intex * .1)));
    var letterGrade = ' ';

    /* if statements to determine letter grade */
    if (overallGrade < 60) {
        letterGrade = 'E';
    }
    else if (overallGrade < 64) {
        letterGrade = 'D-';
    }
    else if (overallGrade < 67) {
        letterGrade = 'D';
    }
    else if (overallGrade < 70) {
        letterGrade = 'D+';
    }
    else if (overallGrade < 74) {
        letterGrade = 'C-';
    }
    else if (overallGrade < 77) {
        letterGrade = 'C';
    }
    else if (overallGrade < 80) {
        letterGrade = 'C+';
    }
    else if (overallGrade < 84) {
        letterGrade = 'B-';
    }
    else if (overallGrade < 87) {
        letterGrade = 'B';
    }
    else if (overallGrade < 90) {
        letterGrade = 'B+';
    }
    else if (overallGrade < 94) {
        letterGrade = 'A';
    }
    else {
        letterGrade = 'A+';
    }
    
    /* send score back to html element */
    $("#score").html("You're final score is: " + overallGrade + "% which is a(n) " + letterGrade + "!");
})