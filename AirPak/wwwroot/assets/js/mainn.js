(function ($) {
    "use strict";

    /*-- Commons Variables -----------------------------------*/
    var $window = $(window),
        $body = $('body'),
        $scrollUp = $('#scroll-top');

    /*-- Custom script to call Background Image & Color from html data attribute -----------------------------------*/
    $('[data-bg-image]').each(function () {
        var $this = $(this);
        $this.css('background-image', 'url(' + $this.data('bg-image') + ')');
    });

    $('[data-bg-color]').each(function () {
        var $this = $(this);
        $this.css('background-color', $this.data('bg-color'));
    });

    /*-- Sidebar Search Active --------------------------------*/
    function sidebarSearch() {
        var searchTrigger = $('.header-search-toggle'),
            endTriggersearch = $('button.search-close'),
            container = $('.main-search-active');

        searchTrigger.on('click', function () {
            container.addClass('inside');
        });

        endTriggersearch.on('click', function () {
            container.removeClass('inside');
        });
    };
    sidebarSearch();

    /*-- Parallax Motion Animation -----------------------------*/
    $('.scene').each(function () {
        new Parallax(this);
    });

    /*-- Header Sticky ----------------------------------------*/
    $window.on('scroll', function () {
        $('.sticky-header').toggleClass('is-sticky', $window.scrollTop() > 350);
    });

    /*-- Off Canvas Function ----------------------------------*/
    $('.header-mobile-menu-toggle, .mobile-menu-close').on('click', function () {
        $body.toggleClass('mobile-menu-open');
    });

    /*-- Swiper Slider Activation -----------------------------*/
    function initSwiperSlider(selector, options) {
        return new Swiper(selector, options);
    }

    var introSlider = initSwiperSlider('.intro-slider', {
        loop: true,
        speed: 750,
        spaceBetween: 30,
        slidesPerView: 2,
        effect: 'fade',
        navigation: { nextEl: '.home-slider-next', prevEl: '.home-slider-prev' },
    });

    var testimonialSlider = initSwiperSlider('.testimonial-slider', {
        slidesPerView: 1,
        slidesPerGroup: 1,
        centeredSlides: true,
        loop: true,
        speed: 1000,
        spaceBetween: 50,
        autoHeight: true,
        pagination: { el: '.swiper-pagination', type: 'bullets', clickable: true },
        breakpoints: { 1499: { slidesPerView: 3 }, 991: { slidesPerView: 2 }, 767: { slidesPerView: 1 } }
    });

    /*-- Lazy Load Images --------------------------------------*/
    $('img.lazy').each(function () {
        var $img = $(this);
        $img.attr('src', $img.data('src')).removeClass('lazy');
    });

    /*-- Magnific Popup ----------------------------------------*/
    $('.video-popup').magnificPopup({ type: 'iframe' });

    /*-- Scroll Up --------------------------------------------*/
    function scrollToTop() {
        var $lastScrollTop = 0;

        $window.on('scroll', function () {
            var st = $window.scrollTop();
            $scrollUp.toggleClass('show', st < $lastScrollTop && st > 200);
            $lastScrollTop = st;
        });

        $scrollUp.on('click', function (evt) {
            $('html, body').animate({ scrollTop: 0 }, 600);
            evt.preventDefault();
        });
    }
    scrollToTop();

    /*-- Ajax Contact Form ------------------------------------*/
    $('#contact-form').submit(function (e) {
        e.preventDefault();

        var form = $(this),
            formMessages = $('.form-messege'),
            formData = form.serialize();

        $.ajax({
            type: 'POST',
            url: form.attr('action'),
            data: formData
        })
            .done(function (response) {
                formMessages.removeClass('error').addClass('success').text(response);
                form.find('input, textarea').val('');
            })
            .fail(function () {
                formMessages.removeClass('success').addClass('error').text('An error occurred and your message could not be sent.');
            });
    });

    /*-- Isotope Grid Activation --------------------------------*/
    var $isotopeGrid = $('.isotope-grid');
    var $isotopeFilter = $('.isotope-filter');

    $isotopeGrid.imagesLoaded(function () {
        $isotopeGrid.isotope({
            itemSelector: '.grid-item',
            masonry: { columnWidth: '.grid-sizer' }
        });

        AOS.refresh();
    });

    $isotopeFilter.on('click', 'button', function () {
        var $this = $(this),
            $filterValue = $this.attr('data-filter'),
            $targetIsotope = $this.parent().data('target');

        $this.addClass('active').siblings().removeClass('active');
        $($targetIsotope).isotope({ filter: $filterValue });
    });

    /*-- SVG Inject With Vivus ----------------------------------*/
    SVGInject(document.querySelectorAll("img.svgInject"), {
        makeIdsUnique: true,
        afterInject: function (img, svg) {
            new Vivus(svg, { duration: 80 });
        }
    });

    $('[data-vivus-hover]').hover(function () {
        var svg = $(this).find('svg')[0];
        new Vivus(svg, { duration: 50 });
    });

    /*-- AOS Scroll Animation ----------------------------------*/
    AOS.init({
        offset: 40,
        duration: 1000,
        once: true,
        easing: 'ease',
    });

    /*-- Tilt Animation ----------------------------------------*/
    $('.js-tilt').tilt({
        base: window,
        reset: true,
        scale: 1.04,
        reverse: false,
        max: 15,
        perspective: 3000,
        speed: 4000
    });

    /*-- Portfolio Masonry Activation --------------------------*/
    $(window).on('load', function () {
        $('.ag-masonary-wrapper').imagesLoaded(function () {
            $('.messonry-button').on('click', 'button', function () {
                var filterValue = $(this).attr('data-filter');
                $(this).siblings('.is-checked').removeClass('is-checked');
                $(this).addClass('is-checked');
                var $grid = $('.mesonry-list').isotope({ filter: filterValue });
            });
        });
    });

})(jQuery);
