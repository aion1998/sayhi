var sayhi = {};
var tem = new Vue({
    el: '#list',
    data: {
        todos: {Name:'无'}
    }
});
var npageIndex =1;

(function (a, undefined) {
    a.sayhi = {
        run: function () {
            //sayhi.user = user;
            sayhi.pageData = pageData;
            window.alert = function (title, content) {
                //document.getElementById('myModalTitle').innerHTML = title;
                //document.getElementById('myModalContent').innerHTML = content;
                $('#myModalTitle').html(title)
                $('#myModalContent').html(content)
                $('#myModal').modal();

            };
            String.prototype.format = function () {
                if (arguments.length == 0) return this;
                for (var s = this, i = 0; i < arguments.length; i++)
                    s = s.replace(new RegExp("\\{" + i + "\\}", "g"), arguments[i]);
                return s;
            };
        }

    }
  

    var pageData = {
        load: function (url) {
            if (npageIndex == 0) {
                alert("提示", "已经是第一页了");
                npageIndex++;
                return;
            }
            var bd = {
                type: 'get',               
                url: url,
                data: { pageIndex: npageIndex },
                success: function (obj) {
                    var objJson = JSON.parse(obj);
                   
                    if (npageIndex != 1) {
                        if (objJson.length <= 0) {
                            alert("提示", "没有数据了");
                            npageIndex--;
                            return;
                        }                        
                    }
                    tem.todos = objJson;
                    return

                   
                }
            }
            $.ajax(bd);
        },
        upPage: function (url) {
            npageIndex--;
            pageData.load(url);
        },
        nextPage: function (url) {
            npageIndex++;
            pageData.load(url);
        }
    }
    sayhi.run();

})(window)

