$(document).ready(() => {

    let authHeaders = { "Content-Type": "application/json" }
    let request = {
        url: 'http://vako.gearhostpreview.com/api/users',
        method: 'GET',
        headers: authHeaders
    };

    $.ajax(request)
        .then((response) => {
            renderUsers(response);
        })
        .catch(showError);

    function showError(error) {
        let errDiv = $('<div>').attr('id', 'errorDiv').text('Error ' + error.status + ' ' + error.statusText + ' (' + error.responseJSON.error + ')').css('color', 'red').addClass("alert alert-danger fade in");
        $('#app').prepend(errDiv);
        setTimeout(function () {
            errDiv.fadeOut(function () {
                errDiv.remove()
            });
        }, 4000);
    }

    function renderUsers(users) {
        let table = $('<table>').addClass('table table-striped');
        $(table).append($('<thead>').addClass('thead-light').append($('<tr>').append($('<th>').attr('scope', 'col').text('First name')).append($('<th>').attr('scope', 'col').text('Last Name'))));
        for (let user of users) {
            $(table).append($('<tr>').append($('<td>').text(user.FirstName)).append($('<td>').text(user.LastName)));
        }
        $('#app').append(table);
    }
});