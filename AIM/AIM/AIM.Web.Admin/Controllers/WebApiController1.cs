using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TrackableEntities;
using TrackableEntities.Common;
using AIM.Service.Entities.Models;

// NOTE: Primary key name and/or type may need to be set manually.
using TrackableEntities.EF6;

namespace AIM.Web.Admin.Controllers
{
    public class WebApiController1 : ApiController
    {
        private readonly AIM_DBContext _dbContext = new AIM_DBContext();

        // GET api/Question
        [ResponseType(typeof(IEnumerable<Question>))]
        public async Task<IHttpActionResult> GetQuestions()
        {
            IEnumerable<Question> entities = await _dbContext.Questions
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            return Ok(entities);
        }

        // GET api/Question/5
        [ResponseType(typeof(Question))]
        public async Task<IHttpActionResult> GetQuestion(int id)
        {
            Question entity = await _dbContext.Questions
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(e => e.questionId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/Question
        [ResponseType(typeof(Question))]
        public async Task<IHttpActionResult> PostQuestion(Question entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            entity.TrackingState = TrackingState.Added;
            _dbContext.ApplyChanges(entity);


            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (_dbContext.Questions.Any(e => e.questionId == entity.questionId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.questionId }, entity);
        }

        // PUT api/Question
        [ResponseType(typeof(Question))]
        public async Task<IHttpActionResult> PutQuestion(Question entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dbContext.ApplyChanges(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_dbContext.Questions.Any(e => e.questionId == entity.questionId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/Question/5
        public async Task<IHttpActionResult> DeleteQuestion(int id)
        {
            Question entity = await _dbContext.Questions
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(e => e.questionId == id);
            if (entity == null)
            {
                return Ok();
            }

            entity.TrackingState = TrackingState.Deleted;
            _dbContext.ApplyChanges(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_dbContext.Questions.Any(e => e.questionId == entity.questionId))
                {
                    return Conflict();
                }
                throw;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}
