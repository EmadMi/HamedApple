function RegisterBegin(id) {
    $("#RegisterContent").load("/Account/RegisterOnPartial/" + id);
}
$(document).on("submit", "form#RegisterForm", function (e) {
    e.preventDefault();
    var $Form = $(this);
    //
    $.ajax({
        url: '/Account/RegisterOnPartial',
        type: 'POST',
        dataType: 'JSON',
        data: $Form.serialize()
    }).done(function (res) {
        if (res.status) {
            window.location.href = "/Home/Index";
        } else {
            $Form.find('#RegisterMisCompeletes').text('');
            res.errors.forEach(function (error, i) {
                $Form.find('#RegisterMisCompeletes').append(error + "<br/>");
            });
        }
    }).fail(function (text, xhr) {
        $Form.find('#RegisterMisCompeletes').text('در ارسال اطلاعات خطایی رخ داده است.');
    })
});