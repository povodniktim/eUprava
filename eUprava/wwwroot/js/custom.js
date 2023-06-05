window.changeIcon = function (index, iconClass) {
    var iconElement = document.querySelectorAll('.circle-icon .icon')[index];
    if (iconElement) {
        iconElement.classList.remove('fa fa-hand-pointer-o', 'fa-times');
        iconElement.classList.add('fa-' + iconClass);
    }
};
