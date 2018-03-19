$(function () {
    sayhi.pageData.load(sayhi.user.request_page);
});

sayhi.user = {
    request_page: '/FormalSysManagement/ManagingUserPage/GetUserList',
    showAddUserView: function () {
        $('#addUser').modal();
    },
    submitAddUserView: function () {

    },

}