jQuery.noConflict();

(function ($otro) {
  "use strict"; // Start of use strict

  // Toggle the side navigation
  $otro("#sidebarToggle, #sidebarToggleTop").on('click', function(e) {
    $otro("body").toggleClass("sidebar-toggled");
    $otro(".sidebar").toggleClass("toggled");
    if ($otro(".sidebar").hasClass("toggled")) {
        $otro('.sidebar .collapse').collapse('hide');
    };
  });

  // Close any open menu accordions when window is resized below 768px
  $otro(window).resize(function () {
      if ($otro(window).width() < 768) {
          $otro('.sidebar .collapse').collapse('hide');
    };
  });

  // Prevent the content wrapper from scrolling when the fixed side navigation hovered over
  $otro('body.fixed-nav .sidebar').on('mousewheel DOMMouseScroll wheel', function (e) {
      if ($otro(window).width() > 768) {
      var e0 = e.originalEvent,
        delta = e0.wheelDelta || -e0.detail;
      this.scrollTop += (delta < 0 ? 1 : -1) * 30;
      e.preventDefault();
    }
  });

  // Scroll to top button appear
  $otro(document).on('scroll', function () {
    var scrollDistance = $(this).scrollTop();
    if (scrollDistance > 100) {
        $otro('.scroll-to-top').fadeIn();
    } else {
        $otro('.scroll-to-top').fadeOut();
    }
  });

  // Smooth scrolling using jQuery easing
  $otro(document).on('click', 'a.scroll-to-top', function (e) {
      var $anchor = $otro(this);
    $('html, body').stop().animate({
      scrollTop: ($($anchor.attr('href')).offset().top)
    }, 1000, 'easeInOutExpo');
    e.preventDefault();
  });

})(jQuery); // End of use strict
