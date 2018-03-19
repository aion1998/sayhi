


var top_menu = [
  {
      top_name: "角色管理",
      top_place: 2,
      top_link:"/sayhiAdmin/PersonAdmin/Index",
      left_menu: [
          { left_name: "角色列表", admin: "person_list", place: 1, view_url: "xxxx" }
      ]
  },
  {
      top_name: "管理首页",
      top_place: 1,
      top_link: "/sayhiAdmin/SayhiMain/LoginErro?ErroMsg=吓你得",
      left_menu: [
          { left_name: "系统文件(上传,添加,删除,查询,下载)", admin: "sys_file", place: 1 },
          { left_name: "用户文件(查询,废除,锁定)", admin: "use_file", place: 3 },
          { left_name: "网站设置(logo,banner,keywor)", admin: "web_set", place: 2 },
      ]
  },
  {
      top_name: "漫画管理",
      top_place: 3,
      left_menu: [
        { left_name: "漫画列表", admin: "manhua_list", place: 1 },
      ]
  },
  {
      top_name: "Paro管理",
      top_place: 4,
      left_menu: [
           { left_name: "Paro列表", admin: "paro_list", place: 1 },
      ]
  },
  {
      top_name: "玩家管理",
      top_place: 5,
      left_menu: [
           { left_name: "玩家列表", admin: "use_list", place: 1 },
      ]
  },
  {
      top_name: "小说管理",
      top_place: 6,
      left_menu: [
          { left_name: "小说列表", admin: "book_list", place: 1 },
      ]
  }
]

var ln = {};



//加载导航
ln.data = {
    i: 0,
    le: top_menu.length,
    max_name: null,
    max_url: null,
    //加载顶部导航
    load: function () {
        var elMenu = document.getElementById("top-menu");
        var htlStr;
        for (; ln.data.i < ln.data.le; ln.data.i++) {
            var j = 0
            //原始人的排序法
            for (; j < ln.data.le - 1; j++) {
                if (top_menu[j].top_place > top_menu[j + 1].top_place) {
                    var temp = top_menu[j + 1];
                    top_menu[j + 1] = top_menu[j];
                    top_menu[j] = temp;
                }
            }
            var nowmenu = top_menu[ln.data.i];
            if (nowmenu.top_place == 1) {
                max_name = nowmenu.top_name;
                max_url = nowmenu.top_link;
            }
            htlStr += "<li><a href='#' onClick='ln.data.topmenuClick(this)'>" + top_menu[ln.data.i].top_name + "</a></li>";
        }
        elMenu.innerHTML = htlStr;
    },
    //顶部导航点击事件
    topmenuClick: function (obj) {
        var name;
        if (max_name != null) {
            name = max_name;
            max_name = null;
        } else {
            name = obj.innerHTML;
        }
        ln.data.i = 0;
        var i = 0;
        var j = 0;
        //加载left_menu导航
        for (; ln.data.i < ln.data.le; ln.data.i++) {
            if (top_menu[ln.data.i].top_name == name) {
                var leftmenu = top_menu[ln.data.i].left_menu;
                var leftmenu_le = top_menu[ln.data.i].left_menu.length;
                var elMenu = $("#left-menu");
                elMenu.empty()
                for (; i < leftmenu_le; i++) {

                    for (; j < leftmenu_le - 1; j++) {
                        if (leftmenu[j].place > leftmenu[j + 1].place) {
                            var temp = leftmenu[j + 1];
                            leftmenu[j + 1] = leftmenu[j];
                            leftmenu[j] = temp;
                        }
                    }

                    elMenu.append("<li><a href='#' onClick='ln.leftmenuclick(this)'>" + leftmenu[i].left_name + "</a></li>")
                }
                //加载默认内容页面
                document.getElementById('content').innerHTML = ln.data.ajaxload(top_menu[ln.data.i].top_link+'?id=2');
                
            }
        }

        return false;
    },
    ajaxload: function (local) {
        var htmlobj = $.ajax({ url: local, async: false });
        return htmlobj.responseText

    }
}

ln.data.load();//顶部导航的加载
ln.data.topmenuClick();//默认的左侧导航
//ln.data.unit_content();//默认内容页





//var left_menu = {
//    person: {
//        name: "角色管理",
//        alink: "xxx.html",//跳转页面
//        child: {
//            list: {
//                name: "角色列表",
//                data_list_api: "xxx/xx",
//                data_add_api: "xx/xx",
//                load_data: function (el, callback) {
//                    //加载数据
//                },
//                add_data: function (parm) {
//                    //添加数据
//                },
//                del_data: function (id) {
//                    //删除数据
//                }

//            }
//        }
//    }
//}