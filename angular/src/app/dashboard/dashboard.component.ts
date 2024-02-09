import { Component, ViewChild } from '@angular/core';
import {
  ChartComponent,
  ApexNonAxisChartSeries,
  ApexResponsive,
  ApexAxisChartSeries,
  ApexChart,
  ApexXAxis,
  ApexDataLabels,
  ApexStroke,
  ApexMarkers,
  ApexYAxis,
  ApexGrid,
  ApexTitleSubtitle,
  ApexLegend
} from "ng-apexcharts";

export type ChartOptions = {
  series: ApexNonAxisChartSeries;
  chart: ApexChart;
  responsive: ApexResponsive[];
  labels: any;
};

export type ChartLineOptions = {
  lineseries: ApexAxisChartSeries;
  chartLine: ApexChart;
  xaxis: ApexXAxis;
  stroke: ApexStroke;
  dataLabels: ApexDataLabels;
  markers: ApexMarkers;
  tooltip: any; // ApexTooltip;
  yaxis: ApexYAxis;
  grid: ApexGrid;
  legend: ApexLegend;
  title: ApexTitleSubtitle;
};

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent {
  @ViewChild("chart") chart: ChartComponent;
  public chartOptions: Partial<ChartOptions>;
  @ViewChild("chartLine") chartLine: ChartComponent;
  public ChartLineOptions: Partial<ChartLineOptions>;

  constructor() {
    this.chartOptions = {
      series: [44, 55, 13, 43, 22],
      chart: {
        type: "donut"
      },
      labels: ["Team A", "Team B", "Team C", "Team D", "Team E"],
      responsive: [
        {
          breakpoint: 480,
          options: {
            chart: {
              width: 100,
              height: 400,
            },
            legend: {
              position: "bottom"
            }
          }
        }
      ]
    };

  this.ChartLineOptions = {
    lineseries: [
      {
        name: "Critical",
        data: [45, 52, 38, 24, 33, 26, 21, 20, 6, 8, 15, 10]
      },
      {
        name: "High",
        data: [35, 41, 62, 42, 13, 18, 29, 37, 36, 51, 32, 35]
      },
      {
        name: "Mdeium",
        data: [87, 57, 74, 99, 75, 38, 62, 47, 82, 56, 45, 47]
      },
      {
        name: "Low",
        data: [23, 38, 50, 30, 11, 10, 20, 34, 32, 38, 28, 20]
      },
    ],
    chartLine: {
      height: 350,
      type: "line"
    },
    dataLabels: {
      enabled: false
    },
    stroke: {
      width: 5,
      curve: "smooth",
      dashArray: [0, 0, 0]
    },
    title: {
      text: "Trending",
      align: "left"
    },
    legend: {
      tooltipHoverFormatter: function(val, opts) {
        return (
          val +
          " - <strong>" +
          opts.w.globals.series[opts.seriesIndex][opts.dataPointIndex] +
          "</strong>"
        );
      }
    },
    markers: {
      size: 0,
      hover: {
        sizeOffset: 6
      }
    },
    xaxis: {
      labels: {
        trim: false
      },
      categories: [
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "June",
        "July",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"
      ]
    },
    tooltip: {
      y: [
        {
          title: {
            formatter: function(val) {
              return val + " (mons)";
            }
          }
        },
        {
          title: {
            formatter: function(val) {
              return val + " per session";
            }
          }
        },
        {
          title: {
            formatter: function(val) {
              return val;
            }
          }
        }
      ]
    },
    grid: {
      borderColor: "#f1f1f1"
    }
  };

}


}
