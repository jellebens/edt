'use strict';
angular.module('EdtApp').controller('solarSystemCreateController', ['$scope', function ($scope) {
    $scope.economies = [
        { Name: 'Extraction' },
        { Name: 'Refinery' },
        { Name: 'Agriculture' },
        { Name: 'Industrial' },
        { Name: 'High Tech' }
    ];


    $scope.commodities = [
            {
                Name: 'Chemicals', Commodities: [
                                       { Name: 'Agricultural Medicines' },
                                       { Name: 'Explosives' },
                                       { Name: 'Hydrogen Fuel' },
                                       { Name: 'Mineral Oil' },
                                       { Name: 'Pesticides' }
                ]
            },
            {
                Name: 'Consumer Items', Commodities: [
                                       { Name: 'Clothing' },
                                       { Name: 'Consumer Technology' },
                                       { Name: 'Domestic Appliances' }
                ]
            },
            {
                Name: 'Drugs', Commodities: [
                    { Name: 'Basic Narcotics' },
                    { Name: 'Beer' },
                    { Name: 'Liquor' },
                    { Name: 'Tobacco' },
                    { Name: 'Wine' }]
            },
            {
                Name: 'Foods', Commodities: [{ Name: 'Algae' },
                                            { Name: 'Animal Meat' },
                                            { Name: 'Coffee' },
                                            { Name: 'Fish' },
                                            { Name: 'Food Cartridges' },
                                            { Name: 'Fruit' },
                                            { Name: 'Grain' },
                                            { Name: 'Synthetic Meat' },
                                            { Name: 'Tea' }
                ]
            },
            {
                Name: 'Industrial Materials', Commodities: [{ Name: 'Polymers' },
                                                            { Name: 'Semiconductors' },
                                                            { Name: 'Superconductors' }
                ]
            },
            { Name: 'Machinery', Commodities: [] },
            { Name: 'Medicines', Commodities: [] },
            { Name: 'Metals', Commodities: [] },
            { Name: 'Minerals', Commodities: [] },
            { Name: 'Technology', Commodities: [] },
            { Name: 'Textiles', Commodities: [] },
            { Name: 'Waste', Commodities: [] },
            { Name: 'Weapons', Commodities: [] }


    ];

    $scope.economy = undefined;
}]);