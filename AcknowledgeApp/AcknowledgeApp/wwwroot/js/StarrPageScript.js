$(window).on('load', function () {
    $('#myModal').modal('show');
});
$('#smileys input').on('click', function () {
    $('#result').html($(this).val());
});