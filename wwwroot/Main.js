
function mainSlider() {



    $('.owl-main').owlCarousel({
        loop: true,
        margin: 0,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        autoplay: true,
        autoplayTimeout: 7000,
        autoplayHoverPause: false,
        responsive: {
            320: {
                items: 1
            }
            ,
            1920: {
                items: 1
            }
        }
    });
}

function mainModal(){
    $('#myModal').on('shown.bs.modal', function () {
        $('#myInput').trigger('focus')
      })
}