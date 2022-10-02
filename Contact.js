var contactForm = contactForm ||
{
    unit: function () {
        this.listeners();
    },
    listeners: function () {
        $(document).on('click', '.contact-submit', function () {
            e.preventDefaut();
            var form = $("#contact-form");
            form.submit();
        });
    },
    showResult: function () {
        $('#form-outer').hide('slow');
        $('#form-result').show('slow');
    }
}

