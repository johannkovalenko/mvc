// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("button.owners").click(
    function() {
        var id = $(this).data('id');
        $("div.interim").remove();
        $.get( "Home/Details", {id:id}, function( data ) {
            $('table.main > tbody > tr').eq(id).after(data);
        });
    }
);