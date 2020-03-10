var ctx = document.getElementById('chart2').getContext('2d');
var chart = new Chart(ctx, {
    // The type of chart we want to create
    type: 'pie',

    // The data for our dataset
    data: {
        labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
        datasets: [{
            label: '# of Permits',
            backgroundColor: [
                'rgba(191, 63, 63, 1)',
                'rgba(120, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            data: [15, 35, 100, 65, 7, 35]
        }]
    },

    // Configuration options go here
    options: {
        title:{
            text: 'Building Type',
            position: 'top',
            display: true
        },
        legend:{
            display: false
        }
    }
});