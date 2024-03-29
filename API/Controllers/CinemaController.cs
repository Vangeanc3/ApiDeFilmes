﻿using API.Models;
using API.Models.Dtos.CinemaDto;
using AutoMapper;
using FilmesAPI.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : Controller
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public CinemaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinema);
        }

        [HttpGet]
        public IEnumerable<Cinema> RecuperaCinemas([FromQuery] string nomeDoFilme)
        {
            return _context.Cinemas;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCinemasPorId(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema != null)
            {
                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return Ok(cinemaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            _mapper.Map(cinemaDto, cinema);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCinema(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            _context.Remove(cinema);
            _context.SaveChanges();
            return NoContent();
        }

    }
}






































//namespace API.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class CinemaController : ControllerBase
//    {
//        private AppDbContext _context;
//        private IMapper _mapper;

//        public CinemaController(AppDbContext context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }
//        [HttpPost]
//        public IActionResult CriarCinema([FromBody] CreateCinemaDto cinemaDto)
//        {
//            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
//            _context.Cinemas.Add(cinema);
//            _context.SaveChanges();
//            return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinema);
//        }

//        [HttpGet]
//        public IEnumerable<Cinema> RecuperaCinema([FromQuery] string nomeDoFilme)
//        {
//            return _context.Cinemas;
//        }
//        [HttpGet("{id}")]
//        public IActionResult RecuperaCinemasPorId(int id)
//        {
//            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
//            if (cinema != null)
//            {
//                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
//                return Ok(cinemaDto);
//            }
//            return NotFound();
//        }

//        [HttpPut("{id}")]
//        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
//        {
//            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
//            if (cinema == null)
//            {
//                return NotFound();
//            }
//            _mapper.Map(cinemaDto, cinema);
//            _context.SaveChanges();
//            return NoContent();
//        }


//        [HttpDelete("{id}")]
//        public IActionResult DeletaCinema(int id)
//        {
//            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
//            if (cinema == null)
//            {
//                return NotFound();
//            }
//            _context.Remove(cinema);
//            _context.SaveChanges();
//            return NoContent();
//        }
//    }
//}