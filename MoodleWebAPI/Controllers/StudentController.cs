using Moodle.Bll.Contracts;
using Moodle.Bll.Models;
using MoodleWebAPI.Mappers;
using MoodleWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoodleWebAPI.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentController : ApiController
    {
        private IStudentService _iStudentService;
        private IStudentAPIMapper _iStudentAPIMapper;

        public StudentController()
        {

        }

        public StudentController(IStudentService iStudentService, IStudentAPIMapper iStudentAPIMapper)
        {
            _iStudentService = iStudentService;
            _iStudentAPIMapper = iStudentAPIMapper;
        }

        //Get api/values
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<StudentAPIModel> GetAll()
        {
            var studentModelList = _iStudentService.GetAll();
            List<StudentAPIModel> studentAPIModelList = new List<StudentAPIModel>();

            foreach (StudentModel student in studentModelList)
            {
                studentAPIModelList.Add(_iStudentAPIMapper.Map(student));
            }

            return studentAPIModelList;
        }

        [HttpGet]
        [Route("GetBy/{username}")]
        public HttpResponseMessage Get(string username)
        {
            var result = _iStudentService.GetByUsername(username);

            if (result == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        //POST api/values
        [HttpPost]
        [Route("AddStudent")]
        public HttpResponseMessage Create([FromBody] StudentAPIModel studentAPIModel)
        {
            if (_iStudentService.GetByUsername(_iStudentAPIMapper.Map(studentAPIModel).Username) != null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Username already used!");
            }

            else
                if (studentAPIModel == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            else
            {
                _iStudentService.AddStudent(_iStudentAPIMapper.Map(studentAPIModel));
                return Request.CreateResponse(HttpStatusCode.Created, _iStudentAPIMapper.Map(studentAPIModel));
            }
        }

        //PUT api/values/username
        [HttpPut]
        [Route("UpdateStudent/{username}")]
        public HttpResponseMessage Update([FromBody]StudentAPIModel studentAPIModel)
        {
            if (studentAPIModel == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            if (_iStudentService.CheckIsStudentExists(studentAPIModel.Username) == true)
            {
                _iStudentService.UpdateStudent(_iStudentAPIMapper.Map(studentAPIModel));
                return Request.CreateResponse(HttpStatusCode.Created, _iStudentAPIMapper.Map(studentAPIModel));
            }
            else
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Student is not enrolled in this class!");
        }

        //DELETE api/values
        [HttpDelete]
        [Route("DeleteStudent/{username}")]
        public HttpResponseMessage Delete(string username)
        {
            var student = _iStudentService.GetByUsername(username);
            if (student == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                _iStudentService.DeleteStudent(student);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
    }

}