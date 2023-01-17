<h1 align="center" id="top">Azure IoTHub Demo: HydroVision</h1>

## Table of contents
- [About This Project](#about-this-project)
- [Why Is Water Quality Measuring Important?](#why-is-water-quality-measuring-important?)
- [How Do We Measure Water Quality?](#how-do-we-measure-water-quality?)
- [What is HydroVision?](#what-is-hydrovision?)
- [Components/Services](#components/services)
- [Overview/Structure](#overview/structure)
- [Sources](#sources)

## About This Project

## Why Is Water Quality Measuring Important?

One of the most pressing issues of our age is undoubtedly climate change and the outcome associated with it; drastic environmental changes and natural disasters. Even in the short term, water is an essential part of our everyday lives. Water is vital in everything from household necessities to large-scale applications in our societal and industrial infrastructure. It wouldn’t be an overstatement to say that water is the lifeblood of both our planet and our society.

## How Do We Measure Water Quality?

Measuring the quality of a body of water is far from a simple task; rather than measuring a single metric one would have to measure numerous metrics and values to properly ascertain the quality of a body of water.

Some of the metrics one would typically measure are:

- pH value
- ORP (Oxygen Reduction Potential)
- Conductivity
- Amount of dissolved oxygen
- Residual Chlorine
- Turbidity
- Salinity
- Ozone
- COD (Chemical Oxygen Demand/dissolved organic contaminants)
- Ammonia Nitrogen Ion (NH3-N)
- TOC (Total Organic Carbon)

To this end there are a multitude of sensors already available on the market that one would use in combination with each other to build a water quality monitoring system. It would make little sense to reinvent the wheel in this respect.

## What is HydroVision?

What HydroVision seeks to do is to give a holistic, large-scale overview of the change in water quality over time in large areas with multiple nearby bodies of water. The sensor data collected from the sensors would then be stored in one or several databases from which this data can be visualized in the form of graphs, tables or charts as desired.

In tandem with local weather data over time as well as air quality over time (both of which could be collected using APIs if no sensor infrastructure exists to measure these) it would be possible to gain deeper insight into which factors might contribute to changes in water quality in large areas.

The benefit of combining weather data and air quality with the water quality monitoring system would be to examine if a possible correlation or overall trend can be found between these, or alternatively make it possible to rule these factors out if such a correlation or trend cannot be found. For instance, if both water quality and air quality in a given area are seeing a noticeable decline it could be possible to see if nearby sources of pollution have caused this.

The more information and data one would integrate into this system the better. To refer back to the aforementioned example, the monitoring could further be combined with detailed maps of the local area with information of which populated areas are closest, what kinds of industries or factories are based in those areas and which modes of transport are most used in the area to more easily see possible correlations and thus more effectively be able to formulate long-term plans or efforts to combat or minimize the impact this might have on the environment. A system like this if built upon a solid foundation of IoT, Big Data, scalability and powerful visualization tools can therefore be a very flexible and versatile asset to any company, organization or government that wishes to gain more insight into the quality of water and air in their local environment to better address any potential issues and/or how they are currently affecting it.

How I personally visualize HydroVision as a concept is as a way to gather and showcase massive amounts of information in an easily-understood way. I also believe it is very important that the system be expandable and scalable so that it can better serve the needs of its users. While it might be tempting to integrate all manner of additional features and use cases onto the service I feel this is likely to lead to bloat, feature creep and user confusion. By making the service as lean and simplistic as possible in its base form it becomes easier for users of varying levels of knowledge, experience or familiarity to get comfortable with the service and thus would also serve to drive down costs. At the same time the service should not be so simplified as to lack the necessary features to serve its primary purpose or so locked down that it cannot be expanded upon or modified to adapt to different needs and use cases.

## Components/Services

Some of the required sensors for the HydroVision project are listed in the section titled "How Do We Measure Water Quality?". For the purposes of this demo these will not be utilized. Instead, a rough proof of concept utilizing a Arduino Uno set up with a DHT11 to act as a temperature and humidity sensor will collect sensor data where it is then meant to be sent to a database housed in Azure in the form of a JSON file where the data can then be extracted and visualised as a graph, table, chart, map or the like.

The HydroVision project as envisioned in its completed state would also support large clusters of sensors as well as the server/database infrastructure necessary to store and handle all the collected server data. It would also support receiving sensor data from one or several API as well as add-on software developed by a third party or by the client themself in cases where a more customized implementation is wanted. This is, however, outside of the scope of this demo.

## Overview/Structure

## Sources

[Top 10 Water Quality Sensors For Water Treatments](https://apureinstrument.com/blogs/water-quality-sensors-for-water-treatments/#:~:text=The%20water%20quality%20sensors%20measure,for%20researchers%2C%20observers%20and%20engineers./) (Apure, 2022)

[How Sensors Can Measure Water Quality](https://www.azosensors.com/article.aspx?ArticleID=1444/) (AZO Sensors, 2018)
