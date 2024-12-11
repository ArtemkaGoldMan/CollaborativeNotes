using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Service.Contracts
{
    public interface INoteService
    {
        Task<IEnumerable<NoteDto>> GetAllNotesAsync();
        Task<NoteDto> GetNoteByIdAsync(int id);
        Task<NoteDto> CreateNoteAsync(NoteDto noteDto);
        Task<NoteDto> UpdateNoteAsync(int id, NoteDto noteDto);
        Task<bool> DeleteNoteAsync(int id);
    }
}
