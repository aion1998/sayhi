

$(function () {
   

    window.alert = function (title, msg) {
        if (title == null) { title = "Sayhi" }
        $('#alert-title').html(title)
        $('#alert-msg').html(msg)
        $('#alert').modal();
    }
    window.confirm = function (title, msg) {
        if (title == null) { title = "Sayhi" }
        $('#confirm-title').html(title)
        $('#confirm-msg').html(msg)
        $('#confirm').modal({
            relatedElement: this,
            onConfirm: function () {
                return true;
            },
            onCancel: function () {
                return false;
            }
        });       
    }
    window.prompt = function (msg) {
       
    }

    var sayhi = {};
    sayhi.loading = function () {
        $('#loading').modal();
    }
    sayhi.action = function () {
        
        $('#actions').modal();
    }
    sayhi.popup = function (title,content) {

        $('#popup').modal();
    }
    //菜单导航
    $('.menu-link-li>a').mouseover(function () {
        $('.menu-down-list').hide();
        var _next = $(this).next();
        _next.show();
    })

  

    //$('#uName').hover(function () {
    //    $('.user_down_list').show(500);
    //}, function () {
    //    $('.user_down_list').hide(500);
    //})

    //用户导航
   
    $('#uName').click(function () {
        $('.user_down_list').toggle(100)
    });
   



});