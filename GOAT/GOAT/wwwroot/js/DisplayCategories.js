
$(document).ready(function () {
    $('#table').DataTable();
});


$('#modal').on('shown.bs.modal', function () {
    $('#viewBtn').trigger('focus')
})
