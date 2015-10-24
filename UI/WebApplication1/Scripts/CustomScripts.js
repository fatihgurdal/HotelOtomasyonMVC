$(function () {
	$("button").removeAttr('disabled');

});

function DeletePostToAction(id,confirmStr,postUrl,errorDivId,toDirectAction,isdirect,thisDiv)
{
	if (confirm(confirmStr)) {
		$.ajax({
			type: "POST",
			url: postUrl,
			data: { "id": id },
			dataType: "json",
			success: function (data) {
				if (data) {
					if (isdirect) {
					    window.location.replace(toDirectAction);
					} else {
						$("#" + thisDiv + id).remove();
						$("#" + errorDivId).css("visibility", "hidden");
					}

				} else {
					$("#NationalityError").css("visibility", "visible");
				}

			}
		});
	}
}