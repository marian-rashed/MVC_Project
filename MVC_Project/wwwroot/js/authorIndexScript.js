$('.AlphabetNav a').click(function (evt) {
    evt.preventDefault();

    var $navItem = $(this),
        $contacts = $('.Contact');

    $contacts.show();

    if ($navItem.hasClass('active')) {
        $navItem.removeClass('active');
    } else {
        $('.AlphabetNav a').removeClass('active');
        $navItem.addClass('active');

        $.each($contacts, function (key, contact) {
            var $contact = $(contact),
                $contactName = $contact.find('.Contact-name'),
                $nameArr = $contactName.text().split(' ');

            console.log($nameArr[0].split('')[0].toLowerCase());

            if ($nameArr[0].split('')[0].toLowerCase() !== $navItem.text().toLowerCase()) {
                $contact.hide();
            }
        });
    }
});