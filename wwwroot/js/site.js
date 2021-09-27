// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('a.owners').click(
    function(event) {
        var id = $(this).data('id');
        $("div.interim").remove();
        $.get( "Home/Details", {id:id}, function( data ) {
            $('table.main > tbody > tr').eq(id).after(data);
        });
        
        event.preventDefault();
        event.stopPropagation();
    }
);

$("button.linkowner").click(
    function() {
        var companyId = $(this).data('id');
        var ownerID = $("input:checked").val();

        $.get( "Home/LinkRecordTemp", {companyId:companyId, ownerID:ownerID}, function( data ) {
            alert(data);
        });

        $(".toggle").toggle();
    }
);
$(".toggle").toggle();

$('button.linkcompany').click(function() {
    $(".toggle").toggle();
})