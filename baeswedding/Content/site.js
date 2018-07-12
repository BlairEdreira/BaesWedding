﻿$(document).ready(function () {


    //Shrink Nav
    $(window).scroll(function () {
        if ($(document).scrollTop() > 50) {
            $('.blairandavery').addClass('shrink');
            $('.navbar').addClass('navshrink');


        } else {
            $('.blairandavery').removeClass('shrink');
            $('.navbar').removeClass('navshrink');

        }
    });
    //Smoother scrolling
    $("a").on('click', function (event) {
        if (this.hash !== "") {
            event.preventDefault();
            var hash = this.hash;
            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 800, function () {
                window.location.hash = hash;
            });
        }
    });
    // open rsvp from nav
    $('#openRSVP').click(function (event) {
        event.preventDefault();

        $('#RSVPModal').modal('show');
    })

    // going not going
    $('.rsvp_container').hide();
    $('.rsvp_answer').click(function () {
        $('.rsvp_answer').removeClass('active');
        $(this).addClass('active');
        $('.rsvp_submit').show();
        var content = $(this).data('content');
        if (content === 'rsvp_going') {
            $('#rsvp_yes').fadeIn(750);
            $('.rsvp_optional').fadeIn(750);
            $('.response_header').text('Awesome.');
            $('#rsvp_YESorNO').val("true");
        } else {
            $('#rsvp_yes').fadeIn(750);
            $('.rsvp_optional').fadeOut(0);
            $('.response_header').text("Sorry you can't make it!");
            $('#rsvp_YESorNO').val("false");
        }
    });
    // guest number select
    $('#guest_select').change(function () {
        var count = $(this).val();
        var htmlContent = "";
        for (var i = 0; i < count; i++) {
            htmlContent = htmlContent
                + '<div class="col-lg-12">'
                + '<h6>Guest ' + (i + 1) + '</h6>'
                + '</div>'
                + '<div class="col-lg-6 col-sm-12">'
                + '<div class="form-group">'
                + '<label for="response_fname">*First Name</label>'
                + '<input type="text" class="form-control" id="Guest_' + (i + 1) + '_Fname" name="response_guest_' + (i + 1) + '_fname" required>'
                + '</div>'
                + '</div>'
                + '<div class="col-lg-6 col-sm-12">'
                + '<div class="form-group">'
                + '<label for="response_lname">*Last Name</label>'
                + '<input type="text" class="form-control" id="Guest_' + (i + 1) + '_Lname" name="response_guest_' + (i + 1) + '_lname" required>'
                + '</div>'
                + '</div>';

        }
        $('#guest_container').html(htmlContent);
    });

    // RSVP MODAL
    $("#rsvpForm").validate({
        rules: {
            response_fname: "required",
            response_lname: "required",
            response_email: "required"
        },
        messages: {
            response_fname: "Please enter your first name",
            response_lname: "Please enter your last name",
            response_email: "Please enter your email or 'none@gmail.com' if you do not have one"
        },
        submitHandler: function () {
            if ($('#submit_rsvp').hasClass('disabled')) {
                $.ajax({
                    type: "POST",
                    url: 'Shared/AddGuest',
                    dataType: "HTML",
                    data: {
                    },
                    success: function () {
                    },
                    error: function () {
                        toastr.warning("You already RSVPd", "Hold up!", {
                            "closeButton": true,
                            "debug": false,
                            "newestOnTop": true,
                            "progressBar": false,
                            "positionClass": "toast-bottom-full-width",
                            "preventDuplicates": true,
                            "onclick": null,
                            "showDuration": "300",
                            "hideDuration": "1000",
                            "timeOut": "5000",
                            "extendedTimeOut": "1000",
                            "showEasing": "swing",
                            "hideEasing": "linear",
                            "showMethod": "fadeIn",
                            "hideMethod": "fadeOut"
                        });
                    }
                });
            } else {


                var lastname = ($('#response_lname').val() ? $('#response_lname').val() : "none"),
                    firstname = ($('#response_fname').val() ? $('#response_fname').val() : "none"),
                    email = ($('#response_email').val() ? $('#response_email').val() : "none"),
                    comment = ($('#response_comment').val() ? $('#response_comment').val() : "none"),
                    guest1fn = ($('#Guest_1_Fname').val() ? $('#Guest_1_Fname').val() : "none"),
                    guest1ln = ($('#Guest_1_Lname').val() ? $('#Guest_1_Lname').val() : "none"),
                    guest2fn = ($('#Guest_2_Fname').val() ? $('#Guest_2_Fname').val() : "none"),
                    guest2ln = ($('#Guest_2_Lname').val() ? $('#Guest_2_Lname').val() : "none"),
                    guest3fn = ($('#Guest_3_Fname').val() ? $('#Guest_3_Fname').val() : "none"),
                    guest3ln = ($('#Guest_3_Lname').val() ? $('#Guest_3_Lname').val() : "none"),
                    guest4fn = ($('#Guest_4_Fname').val() ? $('#Guest_4_Fname').val() : "none"),
                    guest4ln = ($('#Guest_4_Lname').val() ? $('#Guest_4_Lname').val() : "none"),
                    guest5fn = ($('#Guest_5_Fname').val() ? $('#Guest_5_Fname').val() : "none"),
                    guest5ln = ($('#Guest_5_Lname').val() ? $('#Guest_5_Lname').val() : "none"),
                    guest6fn = ($('#Guest_6_Fname').val() ? $('#Guest_6_Fname').val() : "none"),
                    guest6ln = ($('#Guest_6_Lname').val() ? $('#Guest_6_Lname').val() : "none"),
                    guest7fn = ($('#Guest_7_Fname').val() ? $('#Guest_7_Fname').val() : "none"),
                    guest7ln = ($('#Guest_7_Lname').val() ? $('#Guest_7_Lname').val() : "none"),
                    guest8fn = ($('#Guest_8_Fname').val() ? $('#Guest_8_Fname').val() : "none"),
                    guest8ln = ($('#Guest_8_Lname').val() ? $('#Guest_8_Lname').val() : "none"),
                    guest9fn = ($('#Guest_9_Fname').val() ? $('#Guest_9_Fname').val() : "none"),
                    guest9ln = ($('#Guest_9_Lname').val() ? $('#Guest_9_Lname').val() : "none"),
                    guest10fn = ($('#Guest_10_Fname').val() ? $('#Guest_10_Fname').val() : "none"),
                    guest10ln = ($('#Guest_10_Lname').val() ? $('#Guest_10_Lname').val() : "none"),
                    attending = $('#rsvp_YESorNO').val();
                $.ajax({
                    type: "POST",
                    url: 'Shared/AddGuest',
                    dataType: "HTML",
                    data: {
                        LastName: lastname,
                        FirstName: firstname,
                        Email: email,
                        Comment: comment,
                        Guest_1_Fname: guest1fn,
                        Guest_1_Lname: guest1ln,
                        Guest_2_Fname: guest2fn,
                        Guest_2_Lname: guest2ln,
                        Guest_3_Fname: guest3fn,
                        Guest_3_Lname: guest3ln,
                        Guest_4_Fname: guest4fn,
                        Guest_4_Lname: guest4ln,
                        Guest_5_Fname: guest5fn,
                        Guest_5_Lname: guest5ln,
                        Guest_6_Fname: guest6fn,
                        Guest_6_Lname: guest6ln,
                        Guest_7_Fname: guest7fn,
                        Guest_7_Lname: guest7ln,
                        Guest_8_Fname: guest8fn,
                        Guest_8_Lname: guest8ln,
                        Guest_9_Fname: guest9fn,
                        Guest_9_Lname: guest9ln,
                        Guest_10_Fname: guest10fn,
                        Guest_10_Lname: guest10ln,
                        Attending: attending
                    },
                    success: function () {
                        $('#RSVPModal').modal('hide');
                        $('#submit_rsvp').addClass('disabled');
                        toastr.success("We have received your RSVP.", "Success!", {
                            "closeButton": true,
                            "debug": false,
                            "newestOnTop": true,
                            "progressBar": false,
                            "positionClass": "toast-bottom-full-width",
                            "preventDuplicates": true,
                            "onclick": null,
                            "showDuration": "300",
                            "hideDuration": "1000",
                            "timeOut": "5000",
                            "extendedTimeOut": "1000",
                            "showEasing": "swing",
                            "hideEasing": "linear",
                            "showMethod": "fadeIn",
                            "hideMethod": "fadeOut"
                        });
                    },
                    error: function () {
                        toastr.error('You have NOT RSVPd. Please try again!', 'Sorry something went wrong!', {
                            "closeButton": true,
                            "debug": false,
                            "newestOnTop": true,
                            "progressBar": false,
                            "positionClass": "toast-bottom-full-width",
                            "preventDuplicates": true,
                            "onclick": null,
                            "showDuration": "300",
                            "hideDuration": "1000",
                            "timeOut": "5000",
                            "extendedTimeOut": "1000",
                            "showEasing": "swing",
                            "hideEasing": "linear",
                            "showMethod": "fadeIn",
                            "hideMethod": "fadeOut"
                        });
                    }
                });
            }
        }
    })





    // ADMIN GUESTS

    var subcount = 0;
    var totalsubcount = 0;
    $('.guest_card').each(function () {
        sub_count = $(this).find('.sub_guest').length;
        $(this).find('.sub_guestCount').html(sub_count);
        totalsubcount += parseFloat(sub_count);
        console.log(sub_count);
    })

    var guests_going = $('.attending_card').length;
    var guests_notgoing = $('.notattending_card').length;
    var sub_guests_going = totalsubcount;
    var guests_total = guests_going + guests_notgoing + sub_guests_going;
    var guests_amount = ((guests_total) * 150)
    $('.guest_count_attending').html(totalsubcount + guests_going);
    $('.guest_count_notattending').html(guests_notgoing);
    $('.guest_count_total').html(guests_total);
    $('.guest_cost').html(guests_amount);

    // Countdown Timer
    var countDownDate = new Date("Apr 14, 2018 14:30:00").getTime();
    var timerOuter = $("#timer");

    var x = setInterval(function () {
        var now = new Date().getTime();
        var distance = countDownDate - now;
        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hours = Math.floor(distance % (1000 * 60 * 60 * 24) / (1000 * 60 * 60));
        var minutes = Math.floor(distance % (1000 * 60 * 60) / (1000 * 60));
        var seconds = Math.floor(distance % (1000 * 60) / 1000);
        $('.countdown').html(days + " days " + hours + " hours " + minutes + " minutes").fadeIn(500);
        if (distance < 0) {
            clearInterval(x);
            $('.countdown').html("We did it!");
        }
    }, 1000);



});
