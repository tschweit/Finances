var ViewModel = function (data) {
	var self = this;

	data = data || {
		IsNew: true,
		Id: null,
		Description: null,
		Amount: null,
		Date: null,
		ExpenseType: null
	}

	ko.mapping.fromJS(data, null, self);

	self.serializeForm = function (form) {
		var array = form.serializeArray();
		var json = {};

		$.each(array, function () {
			json[this.name] = this.value || "";
		});

		return json;
	}

	self.save = function () {
		$.ajax({
			method: "POST",
			url: "Save",
			data: self.serializeForm($("form")),
			success: function (resp) {
				history.back();
			}
		});
	}
};

$(function () {
	window.viewModel = new ViewModel(initialModel);
	ko.applyBindings(window.viewModel);
});


$(document).ready(function () {
	$(".datepicker").datepicker({
		orientation: "top"
	});
});