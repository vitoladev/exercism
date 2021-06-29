﻿module SpaceAge

type Planet =
    | Mercury   
    | Venus
    | Earth
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let age (planet: Planet) (seconds: int64) : float =
    let earthYearInSeconds = 31_557_600.
    let earthOrbitalYears = float seconds / earthYearInSeconds

    let earthYearsInAOrbit =
        match planet with
        | Mercury -> 0.2408467
        | Venus -> 0.61519726
        | Earth -> 1.0
        | Mars -> 1.8808158
        | Jupiter -> 11.862615
        | Saturn -> 29.447498
        | Uranus -> 84.016846
        | Neptune -> 164.79132

    earthOrbitalYears / earthYearsInAOrbit