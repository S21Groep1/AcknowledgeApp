let SelectedStarrId;


$(document).ready(function () {
     $('#smileys input').on('click', function () {
         $('#result').html($(this).val());
    });
});

function SetStarrId(id) {
    SelectedStarrId = id;
}

function GetStarrId() {
    return SelectedStarrId;
}

function showActionPoints() {
    $('#myModal').modal('show');
}

function AddActionPointToStarr(apId) {
    alert('ActionPointId =' + Number(apId) + 'Starr Id =' + Number(GetStarrId()));

    $.ajax({
        type: "POST",
        url: "/Starr/AddActionPointToStarr/",
        data: JSON.stringify([Number(apId), Number(GetStarrId())]),
        contentType: "application/json; charset=utf-8",
        cache: false,
        complete: function () {
            alert("Actionpoint Added!");
        }
    });
}