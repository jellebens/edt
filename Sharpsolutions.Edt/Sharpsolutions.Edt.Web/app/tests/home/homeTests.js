function WidgetsPage() {
    this.get = function() {
        browser.get(helpers.rootUrl + '/widgets');
    }

    this.widgetRepeater = by.repeater('widget in widgets');
    this.firstWidget = element(this.widgetRepeater.row(0));

    this.widgetCreateForm = element(by.css('.widget-create-form'));
    this.widgetCreateNameField = this.widgetCreateForm.element(by.model('widget.name');
    this.widgetCreateSubmit = this.widgetCreateForm.element(by.buttonText('Create');
}

module.exports = WidgetsPage