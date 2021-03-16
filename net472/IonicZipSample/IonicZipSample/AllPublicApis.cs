﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ionic;
using Ionic.BZip2;
using Ionic.Crc;
using Ionic.Zip;
using Ionic.Zlib;

namespace IonicZipSample
{
    public class AllPublicApis
    {
        private int _int = 0;
        private uint _uint = 0;
        private long _long = 0;
        private byte[] _bytes;
        private bool _bool;
        private SeekOrigin _seekOrigin;

        private byte _byte = 0;
        private string _string;
        private BZip2InputStream _stream;
        private ZipFile _zipFile;
        private ZipEntry _zipEntry;
        private ExtractExistingFileAction _extractExistingFileAction;
        private OpenDelegate _openDelegate;
        private CloseDelegate _closeDelegate;
        private WriteDelegate _writeDelegate;
        private DateTime _datetime;
        private Encoding _encoding;
        private IEnumerable<string> _strings;
        private IEnumerable<ZipEntry> _zipEntries;
        private ICollection<string> _stringsCollection;
        private IReadOnlyCollection<string> _stringsReadOnly;
        private ICollection<ZipEntry> _zipEntriesCollection;
        private TextWriter _textWriter;
        private ReadOptions _readOptions;

        private ZipInputStream _zipInputStream;
        private ZipOutputStream _zipOutputStream;
        private BZip2InputStream _bZip2InputStream;
        private BZip2OutputStream _bZip2OutputStream;
        private ParallelBZip2OutputStream _parallelBZip2OutputStream;
        private CRC32 _crc32;

        private CrcCalculatorStream _crcCalculatorStream;
        private FileSelector _fileSelector;
        private ComHelper _comHelper;
        private CountingStream _countingStream;

        private DeflateStream _deflateStream;
        private GZipStream _gZipStream;
        private ParallelDeflateOutputStream _parallelDeflateOutputStream;
        private IEnumerator<ZipEntry> _zipEntryEnumerator;
        private IEnumerator _enumerator;

        // These two data types are supported in DotNetZip, but only if .NET Framework is targeted.
        //private SelfExtractorFlavor _selfExtractorFlavor;
        //private SelfExtractorSaveOptions _selfExtractorSaveOptions;

        public void CallAll()
        {
            // These two apis are supported in DotNetZip, but only if .NET Framework is targeted.
            //_zipFile.SaveSelfExtractor(_string, _selfExtractorFlavor);
            //_zipFile.SaveSelfExtractor(_string, _selfExtractorSaveOptions);

            //Project: Ionic.Zip
            _bZip2InputStream.Close();
            _bZip2InputStream.Flush();
            _int = _bZip2InputStream.Read(_bytes, _int, _int);
            _int = _bZip2InputStream.ReadByte();
            _long = _bZip2InputStream.Seek(_long, _seekOrigin);
            _bZip2InputStream.SetLength(_long);
            _bZip2InputStream.Write(_bytes, _int, _int);
            _bZip2OutputStream.Close();
            _bZip2OutputStream.Flush();
            _int = _bZip2OutputStream.Read(_bytes, _int, _int);
            _long = _bZip2OutputStream.Seek(_long, _seekOrigin);
            _bZip2OutputStream.SetLength(_long);
            _bZip2OutputStream.Write(_bytes, _int, _int);
            _parallelBZip2OutputStream.Close();
            _parallelBZip2OutputStream.Flush();
            _int = _parallelBZip2OutputStream.Read(_bytes, _int, _int);
            _long = _parallelBZip2OutputStream.Seek(_long, _seekOrigin);
            _parallelBZip2OutputStream.SetLength(_long);
            _parallelBZip2OutputStream.Write(_bytes, _int, _int);
            _crc32.Combine(_int, _int);
            _int = _crc32.ComputeCrc32(_int, _byte);
            _int = _crc32.GetCrc32(_stream);
            _int = _crc32.GetCrc32AndCopy(_stream, _stream);
            _crc32.Reset();
            _crc32.SlurpBlock(_bytes, _int, _int);
            _crc32.UpdateCRC(_byte);
            _crc32.UpdateCRC(_byte, _int);
            _crcCalculatorStream.Close();
            _crcCalculatorStream.Flush();
            _int = _crcCalculatorStream.Read(_bytes, _int, _int);
            _long = _crcCalculatorStream.Seek(_long, _seekOrigin);
            _crcCalculatorStream.SetLength(_long);
            _crcCalculatorStream.Write(_bytes, _int, _int);
            _zipEntriesCollection = _fileSelector.SelectEntries(_zipFile);
            _zipEntriesCollection = _fileSelector.SelectEntries(_zipFile, _string);
            _stringsCollection = _fileSelector.SelectFiles(_string);
            _stringsReadOnly = _fileSelector.SelectFiles(_string, _bool);
            _string = _fileSelector.ToString();
            _bool = _comHelper.CheckZip(_string);
            _bool = _comHelper.CheckZipPassword(_string, _string);
            _comHelper.FixZipDirectory(_string);
            _string = _comHelper.GetZipLibraryVersion();
            _bool = _comHelper.IsZipFile(_string);
            _bool = _comHelper.IsZipFileWithExtract(_string);
            _countingStream.Adjust(_long);
            _countingStream.Flush();
            _int = _countingStream.Read(_bytes, _int, _int);
            _long = _countingStream.Seek(_long, _seekOrigin);
            _countingStream.SetLength(_long);
            _countingStream.Write(_bytes, _int, _int);
            _zipEntry.Extract();
            _zipEntry.Extract(_extractExistingFileAction);
            _zipEntry.Extract(_string);
            _zipEntry.Extract(_string, _extractExistingFileAction);
            _zipEntry.Extract(_stream);
            _zipEntry.ExtractWithPassword(_extractExistingFileAction, _string);
            _zipEntry.ExtractWithPassword(_string);
            _zipEntry.ExtractWithPassword(_string, _extractExistingFileAction, _string);
            _zipEntry.ExtractWithPassword(_string, _string);
            _zipEntry.ExtractWithPassword(_stream, _string);
            _crcCalculatorStream = _zipEntry.OpenReader();
            _crcCalculatorStream = _zipEntry.OpenReader(_string);
            _zipEntry.SetEntryTimes(_datetime, _datetime, _datetime);
            _string = _zipEntry.ToString();
            _zipEntry = _zipFile.AddDirectory(_string);
            _zipEntry = _zipFile.AddDirectory(_string, _string);
            _zipEntry = _zipFile.AddDirectoryByName(_string);
            _zipEntry = _zipFile.AddEntry(_string, _bytes);
            _zipEntry = _zipFile.AddEntry(_string, _openDelegate, _closeDelegate);
            _zipEntry = _zipFile.AddEntry(_string, _writeDelegate);
            _zipEntry = _zipFile.AddEntry(_string, _string);
            _zipEntry = _zipFile.AddEntry(_string, _string, _encoding);
            _zipEntry = _zipFile.AddEntry(_string, _stream);
            _zipEntry = _zipFile.AddFile(_string);
            _zipEntry = _zipFile.AddFile(_string, _string);
            _zipFile.AddFiles(_strings);
            _zipFile.AddFiles(_strings, _bool, _string);
            _zipFile.AddFiles(_strings, _string);
            _zipEntry = _zipFile.AddItem(_string);
            _zipEntry = _zipFile.AddItem(_string, _string);
            _zipFile.AddSelectedFiles(_string);
            _zipFile.AddSelectedFiles(_string, _bool);
            _zipFile.AddSelectedFiles(_string, _string);
            _zipFile.AddSelectedFiles(_string, _string, _bool);
            _zipFile.AddSelectedFiles(_string, _string, _string);
            _zipFile.AddSelectedFiles(_string, _string, _string, _bool);
            _bool = _zipFile.ContainsEntry(_string);
            _zipFile.Dispose();
            _zipFile.ExtractAll(_string);
            _zipFile.ExtractAll(_string, _extractExistingFileAction);
            _zipFile.ExtractSelectedEntries(_string);
            _zipFile.ExtractSelectedEntries(_string, _extractExistingFileAction);
            _zipFile.ExtractSelectedEntries(_string, _string);
            _zipFile.ExtractSelectedEntries(_string, _string, _string);
            _zipFile.ExtractSelectedEntries(_string, _string, _string, _extractExistingFileAction);
            _enumerator = _zipFile.GetNewEnum();
            _zipFile.Initialize(_string);
            _zipFile.RemoveEntries(_zipEntriesCollection);
            _zipFile.RemoveEntries(_stringsCollection);
            _zipFile.RemoveEntry(_zipEntry);
            _zipFile.RemoveEntry(_string);
            _int = _zipFile.RemoveSelectedEntries(_string);
            _int = _zipFile.RemoveSelectedEntries(_string, _string);
            _zipFile.Save();
            _zipFile.Save(_string);
            _zipFile.Save(_stream);
            _zipEntriesCollection = _zipFile.SelectEntries(_string);
            _zipEntriesCollection = _zipFile.SelectEntries(_string, _string);
            _string = _zipFile.ToString();
            _zipEntry = _zipFile.UpdateDirectory(_string);
            _zipEntry = _zipFile.UpdateDirectory(_string, _string);
            _zipEntry = _zipFile.UpdateEntry(_string, _bytes);
            _zipEntry = _zipFile.UpdateEntry(_string, _openDelegate, _closeDelegate);
            _zipEntry = _zipFile.UpdateEntry(_string, _writeDelegate);
            _zipEntry = _zipFile.UpdateEntry(_string, _string);
            _zipEntry = _zipFile.UpdateEntry(_string, _string, _encoding);
            _zipEntry = _zipFile.UpdateEntry(_string, _stream);
            _zipEntry = _zipFile.UpdateFile(_string);
            _zipFile.UpdateFile(_string, _string);
            _zipFile.UpdateFiles(_strings);
            _zipFile.UpdateFiles(_strings, _string);
            _zipFile.UpdateItem(_string);
            _zipFile.UpdateItem(_string, _string);
            _zipFile.UpdateSelectedFiles(_string, _string, _string, _bool);
            _zipInputStream.Flush();
            _zipEntry = _zipInputStream.GetNextEntry();
            _int = _zipInputStream.Read(_bytes, _int, _int);
            _long = _zipInputStream.Seek(_long, _seekOrigin);
            _zipInputStream.SetLength(_long);
            _string = _zipInputStream.ToString();
            _zipInputStream.Write(_bytes, _int, _int);
            _bool = _zipOutputStream.ContainsEntry(_string);
            _zipOutputStream.Flush();
            _zipEntry = _zipOutputStream.PutNextEntry(_string);
            _int = _zipOutputStream.Read(_bytes, _int, _int);
            _long = _zipOutputStream.Seek(_long, _seekOrigin);
            _zipOutputStream.SetLength(_long);
            _string = _zipOutputStream.ToString();
            _zipOutputStream.Write(_bytes, _int, _int);
            _deflateStream.Flush();
            _int = _deflateStream.Read(_bytes, _int, _int);
            _long = _deflateStream.Seek(_long, _seekOrigin);
            _deflateStream.SetLength(_long);
            _deflateStream.Write(_bytes, _int, _int);
            _gZipStream.Flush();
            _int = _gZipStream.Read(_bytes, _int, _int);
            _long = _gZipStream.Seek(_long, _seekOrigin);
            _gZipStream.SetLength(_long);
            _gZipStream.Write(_bytes, _int, _int);
            _parallelDeflateOutputStream.Close();
            _parallelDeflateOutputStream.Flush();
            _int = _parallelDeflateOutputStream.Read(_bytes, _int, _int);
            _parallelDeflateOutputStream.Reset(_stream);
            _long = _parallelDeflateOutputStream.Seek(_long, _seekOrigin);
            _parallelDeflateOutputStream.SetLength(_long);
            _parallelDeflateOutputStream.Write(_bytes, _int, _int);

            // Static
            _bool = ZipFile.CheckZip(_string);
            _bool = ZipFile.CheckZip(_string, _bool, _textWriter);
            _bool = ZipFile.CheckZipPassword(_string, _string);
            ZipFile.FixZipDirectory(_string);
            _bool = ZipFile.IsZipFile(_string);
            _bool = ZipFile.IsZipFile(_string, _bool);
            _bool = ZipFile.IsZipFile(_stream, _bool);
            _zipFile = ZipFile.Read(_string);
            _zipFile = ZipFile.Read(_string, _readOptions);
            _zipFile = ZipFile.Read(_stream);
            _zipFile = ZipFile.Read(_stream, _readOptions);
            _uint = Adler.Adler32(_uint, _bytes, _int, _int);
            _bytes = DeflateStream.CompressBuffer(_bytes);
            _bytes = DeflateStream.CompressString(_string);
            _bytes = DeflateStream.UncompressBuffer(_bytes);
            _string = DeflateStream.UncompressString(_bytes);
            _bytes = GZipStream.CompressBuffer(_bytes);
            _bytes = GZipStream.CompressString(_string);
            _bytes = GZipStream.UncompressBuffer(_bytes);
            _string = GZipStream.UncompressString(_bytes);
            _bytes = ZlibStream.CompressBuffer(_bytes);
            _bytes = ZlibStream.CompressString(_string);
            _bytes = ZlibStream.UncompressBuffer(_bytes);
            _string = ZlibStream.UncompressString(_bytes);
        }
    }
}