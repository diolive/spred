(function () {
    var files,
        $fileInput = $('#changePhotoInput');

    $('#changePhoto').on('click', prepareUpload);

    $fileInput.on('change', Upload);

    function prepareUpload(event) {
        $fileInput.click();
    }


    function Upload(event) {
        files = event.target.files;

        var data = new FormData();
        $.each(files, function (key, value) {
            data.append(key, value);
        });

        $.ajax({
            url: '/Manage/UpdatePhoto',
            type: 'POST',
            data: data,
            cache: false,
            dataType: 'json',
            processData: false, // Don't process the files
            contentType: false, // Set content type to false as jQuery will tell the server its a query string request
            success: function (data, textStatus, jqXHR) {
                if (typeof data.error === 'undefined') {
                    // Success so call function to process the form
                    // submitForm(event, data);
                    console.log('success');
                }
                else {
                    // Handle errors here
                    console.log('ERRORS: ' + data.error);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                // Handle errors here
                console.log('ERRORS: ' + textStatus);
                // STOP LOADING SPINNER
            }
        });
    }

})();