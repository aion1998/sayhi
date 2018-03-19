
$(function () {
    sayhi.pageData.load(sayhi.Managementer.request_page);
    //var _vavli = $('#nav>li');
    //$.each(_vavli,function () {
    //    var s = $(this).childern('a');
    //    console.log(s);
    //})
});

sayhi.Managementer = {
    request_page: '/FormalSysManagement/Managementer/GetAdminList',
    delAdmin: function (_adminId) {

    },
    addAdmin: function () {

    }
}